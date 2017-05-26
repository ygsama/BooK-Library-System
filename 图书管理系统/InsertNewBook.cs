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
    public partial class 新书入库Form : Form
    {
        public 新书入库Form()
        {
            InitializeComponent();
        }

        private string _p;  // p=="1"时为书籍注销操作
        public string P
        {
            get { return _p; }
            set { _p = value; }
        }

        private void 新书入库Form_Load(object sender, EventArgs e)
        {
            if (P != "1")
            {
                书籍注销panel.Visible = false;
            }
        }

        private void 新书入库Btn_Click(object sender, EventArgs e)
        {
            if (bNameTB.Text.Trim() == "" || bAuthorTB.Text.Trim() == "" || bPubComTB.Text.Trim() == "" || ISBN.Text.Trim() == "" || bTagTB.Text.Trim() == "" || bPriceTB.Text.Trim() == "" || bPubDatTB.Text.Trim() == "")
            {
                MessageBox.Show("请填写完整信息", "失败");
            }
            else
            {
                // 自动获得图书序列号
                string sql = " select COUNT(*)+1 from books";
                string bNum = SqlHelper.ExecuteScalar(sql).ToString();
                StringBuilder sb = new StringBuilder(bNum);
                while (sb.Length != 6)
                {
                    sb.Insert(0, "0");
                }
                bNum = sb.ToString();
                
                // 添加操作
                sql = "insert into books values(@bNum,@bName,@bAuthor,@bPubCom,@bPubDat,@ISBN,@bPrice,@bTag)";
                MyDictionary dic = new MyDictionary();
                dic.Add("@bNum", bNum);
                dic.Add("@bName", bNameTB.Text.Trim());
                dic.Add("@bAuthor", bAuthorTB.Text.Trim());
                dic.Add("@bPubCom", bPubComTB.Text.Trim());
                dic.Add("@bPubDat", bPubDatTB.Text.Trim());
                dic.Add("@ISBN", ISBN.Text.Trim());
                dic.Add("@bPrice", bPriceTB.Text.Trim());
                dic.Add("@bTag", bTagTB.Text.Trim());
                int i = SqlHelper.ExecuteNonQuery(sql, dic);
                if (i == 1)
                {
                    MessageBox.Show("添加成功,图书序列号为" + bNum);
                }
            }
        }

        private void 注销书籍Btn_Click(object sender, EventArgs e)
        {
            // 判断账号是否存在
            if (!SqlHelper.IsBookExistsWithNum(注销书籍TB.Text.Trim()))
            {
                MessageBox.Show("书籍不存在", "操作失败");
                return;
            }
            else
            {
                DialogResult dt = MessageBox.Show("确定要注销此书吗", "提示", MessageBoxButtons.OKCancel);
                if (dt != DialogResult.OK)
                {
                    return;
                }
                else
                {
                    string sql = "delete from books where bNum=@bNum";
                    MyDictionary dic = new MyDictionary();
                    dic.Add("@bNum", 注销书籍TB.Text.Trim());
                    int i = SqlHelper.ExecuteNonQuery(sql, dic);
                    if (i == 1)
                    {
                        MessageBox.Show("注销成功");
                    }
                }
                this.Close();
            }
        }
    }
}
