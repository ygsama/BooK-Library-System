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
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (Btn1.Text.Trim() == "")
            {
                MessageBox.Show("账号不能为空");
            }
            else
            {
                ShowBorrowList();
            }
        }

        private void ShowBorrowList()
        {
            string sql = "select ID,uId,bName,bNum,bPrice,borrowDate,returnDate,Tag from borrow where uId =@uId";
            MyDictionary dic = new MyDictionary();
            dic.Add("@uId", uIdTB.Text.Trim());
            DataTable dt = SqlHelper.GetList(sql, dic);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 开关文本框的锁定，将表格内的数据显示到文本框内
            int a = dataGridView1.CurrentRow.Index;
            IDDTB.ReadOnly = false;
            bNameTB.ReadOnly = false;
            bPriceTB.ReadOnly = false;
            bNumTB.ReadOnly = false;
            uuIdTB.ReadOnly = false;
            TagTB.ReadOnly = false;
            borrowDateTB.ReadOnly = false;
            returnDateTB.ReadOnly = false;
            IDDTB.Text = dataGridView1.Rows[a].Cells["ID"].Value.ToString();
            bNameTB.Text = dataGridView1.Rows[a].Cells["bName"].Value.ToString();
            bPriceTB.Text = dataGridView1.Rows[a].Cells["bPrice"].Value.ToString();
            bNumTB.Text = dataGridView1.Rows[a].Cells["bNum"].Value.ToString();
            uuIdTB.Text = dataGridView1.Rows[a].Cells["uId"].Value.ToString();
            TagTB.Text = (dataGridView1.Rows[a].Cells["Tag"].Value.ToString() == "1") ? "是" : "否";
            borrowDateTB.Text = dataGridView1.Rows[a].Cells["borrowDate"].Value.ToString();
            returnDateTB.Text = dataGridView1.Rows[a].Cells["returnDate"].Value.ToString();
            IDDTB.ReadOnly = true;
            bNameTB.ReadOnly = true;
            bPriceTB.ReadOnly = true;
            bNumTB.ReadOnly = true;
            uuIdTB.ReadOnly = true;
            TagTB.ReadOnly = true;
            borrowDateTB.ReadOnly = true;
            returnDateTB.ReadOnly = true;
        }

        #region 处理逾期未还书的用户
        // 窗口加载时处理借书表内逾期的记录 
        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            // 文本框锁定
            IDDTB.ReadOnly = true;
            bNameTB.ReadOnly = true;
            bPriceTB.ReadOnly = true;
            bNumTB.ReadOnly = true;
            uuIdTB.ReadOnly = true;
            TagTB.ReadOnly = true;
            borrowDateTB.ReadOnly = true;
            returnDateTB.ReadOnly = true;

            // Date_Test存储过程
            // 将逾期未还书的标记 (Tag 置为 1)
            // 并将其用户冻结 (uBan 置为 1)
            // create proc Date_Test
            // as 
            // select uId into #A from borrow where convert(varchar(20),GETDATE(),111)>= returnDate group by uId
            // update borrow set Tag='1' where convert(varchar(20),GETDATE(),111)>= returnDate
            // update users set uBan='1' where uId in(select uId from #A)
            // drop table #A
            string sql = "Date_Test";
            MyDictionary dic = new MyDictionary();
            SqlHelper.ExecuteNonQuery(sql, CommandType.StoredProcedure, dic);
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            string sql="select uBan from users where uId=@uID";
            MyDictionary dic3 = new MyDictionary();
            dic3.Add("@uID", uuIdTB.Text.Trim());
            if (SqlHelper.ExecuteScalar(sql, dic3).ToString() == "1")
            {
                MessageBox.Show("因逾期未还书账户被锁定，请及时解锁，并缴纳罚款");
                return;
            }
            else 
            {
                // 办理借书手续
                // 删除借书记录 
                sql = "delete from borrow where ID=@ID";
                MyDictionary dic4 = new MyDictionary();
                dic4.Add("@ID", IDDTB.Text.Trim());
                SqlHelper.ExecuteNonQuery(sql, dic4);

                // 得到书籍库存量 并+1
                sql = "select bTag from books where bNum=@bNum";
                MyDictionary dic5 = new MyDictionary();
                dic5.Add("@bNum", bNumTB.Text.Trim());
                int n = Convert.ToInt32(SqlHelper.ExecuteScalar(sql, dic5)) + 1;

                sql = "update books set bTag=@bTag where bNum=@bNum";
                MyDictionary dic6 = new MyDictionary();
                dic6.Add("@bTag", n.ToString());
                dic6.Add("@bNum", bNumTB.Text.Trim());
                SqlHelper.ExecuteNonQuery(sql, dic6);

                MessageBox.Show("还书提交完成");

                // 刷新借书单
                ShowBorrowList();

            }
        }
    }
}
