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
    public partial class AlterPwdForm : Form
    {
        public AlterPwdForm()
        {
            InitializeComponent();
        }
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        // 权限标记 值admin为管理员 ，值为user则为普通用户
        private string _tag;
        public string _Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }

        private void APbtn_Click(object sender, EventArgs e)
        {
            string sql;
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "")
            {
                MessageBox.Show("请填写完整", "警告");
            }
            else if (textBox2.Text.Trim().Length < 6 || textBox3.Text.Trim().Length < 6)
            {
                MessageBox.Show("新密码长度必须大于六位", "提示");
            }
            else if (textBox2.Text.Trim() != textBox3.Text.Trim())
            {
                MessageBox.Show("两次输入的新密码不一致","警告");
            }
            else
            {
                
                if (_Tag == "user")
                {
                    sql = "update users set uPwd =@uPwd where uId=@uId and uPwd=@uPwdd";

                }
                else
                {
                    sql = "update admin set aPwd = @uPwd where aId=@uId and aPwd=@uPwdd";
                }
                MyDictionary dic1 = new MyDictionary();
                dic1.Add("@uPwd", textBox2.Text.Trim());
                dic1.Add("@uId", Id.ToString());
                dic1.Add("@uPwdd", textBox1.Text.Trim());
                int n = SqlHelper.ExecuteNonQuery(sql, dic1);
                if (n > 0)
                {
                    MessageBox.Show("修改成功", "OK");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("密码错误", "警告");
                }
                
            }
        }
    }
}
