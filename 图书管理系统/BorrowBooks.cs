using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class BorrowBooks : Form
    {
        public BorrowBooks()
        {
            InitializeComponent();
        }

        private void 查书btn_Click(object sender, EventArgs e)
        {
            if (查寻书名tB.Text.Trim() == "")
            {
                MessageBox.Show("书名不能为空");
            }
            else 
            {
                string sql = "select bNum,bName,bAuthor,bPubCom,bPrice,bTag from booksWithbookindex where bName like '%'+ @bName +'%'";
                MyDictionary dic = new MyDictionary();
                dic.Add("@bName", 查寻书名tB.Text.Trim());
                DataTable dt = SqlHelper.GetList(sql, dic);
                dataGridView1.DataSource = dt;
            }
        }

        private void 提交借书_Click(object sender, EventArgs e)
        {
            // 是否存在该用户
            if (uIdTb.Text.Trim() == ""|| comboBox1.Text.ToString().Trim() == "")
            {
                MessageBox.Show("请填写用户名和借阅时间！", "警告");
                return;
            }
            else if (bNumTB.Text.Trim() == "" || bNameTB.Text.Trim() == "" || bPriceTB.Text.Trim() == "")
            {
                MessageBox.Show("请选择书籍！","警告");
            }
            else if (!SqlHelper.IsUserExists(uIdTb.Text.Trim()))
            {
                MessageBox.Show("不存在该用户！", "警告");
                return;
            }
            else
            {
                // 自动获得图书序列号
                string sql = " select COUNT(*)+1 from borrow";
                string ID = SqlHelper.ExecuteScalar(sql).ToString();
                StringBuilder sb = new StringBuilder(ID);
                while (sb.Length != 6)
                {
                    sb.Insert(0, "0");
                }
                ID = sb.ToString();

                // 查询书籍库存量
                sql = "select bTag from books where bNum=@bNum";
                MyDictionary dic1 = new MyDictionary();
                dic1.Add("@bNum", bNumTB.Text.Trim());
                string n = SqlHelper.ExecuteScalar(sql, dic1).ToString();
                if (n == "0")
                {
                    MessageBox.Show("该书籍库存量为零！","警告");
                    return ;
                }

                // 插入数据到借书表（borrow）
                sql = "insert into borrow values(@ID,@uId,@bName,@bNum,@bPrice,convert(varchar(20),GETDATE() ,111),convert(varchar(20),dateadd(day," + comboBox1.Text.ToString().Substring(0, 2) + ",CONVERT(varchar(20),GETDATE() ,111)),111),@Tag)";
                MyDictionary dic = new MyDictionary();
                dic.Add("@ID", ID);
                dic.Add("@uId", uIdTb.Text.Trim());
                dic.Add("@bName", bNameTB.Text.Trim());
                dic.Add("@bNum", bNumTB.Text.Trim());
                dic.Add("@bPrice", bPriceTB.Text.Trim());
                dic.Add("@Tag", "0");// Tag = 0 标记该书未超归还期限 
                int i = SqlHelper.ExecuteNonQuery(sql, dic);
                if (i > 0)
                {
                   n = (Convert.ToInt32(n) - 1).ToString(); // 库存量-1
                    sql = "update books set bTag=@bTag where bNum=@bNum";
                    MyDictionary dic2 = new MyDictionary();
                    dic2.Add("@bTag", n);
                    dic2.Add("@bNum", bNumTB.Text.Trim());
                    SqlHelper.ExecuteScalar(sql, dic2);
                    MessageBox.Show("提交成功");
                }
            }
        }
        // 表格单元格鼠标MouseUp事件
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 开关文本框的锁定，将表格内的数据显示到文本框内
            int a = dataGridView1.CurrentRow.Index;
            bNumTB.ReadOnly = false;
            bNameTB.ReadOnly = false;
            bPriceTB.ReadOnly = false;
            bNumTB.Text = dataGridView1.Rows[a].Cells["bNum"].Value.ToString();
            bNameTB.Text = dataGridView1.Rows[a].Cells["bbName"].Value.ToString();
            bPriceTB.Text = dataGridView1.Rows[a].Cells["bPrice"].Value.ToString();
            bNumTB.ReadOnly = true;
            bNameTB.ReadOnly = true;
            bPriceTB.ReadOnly = true;
        }
    }
}
