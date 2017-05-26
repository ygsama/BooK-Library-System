using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace 图书管理系统
{
    public partial class UpdateIndivForm : Form
    {
        public UpdateIndivForm()
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
        // P标记用来决定是否隐藏panel
        private string _p;
        public string P
        {
            get { return _p; }
            set { _p = value; }
        }

        // 加载个人信息
        private void UpdateIndivForm_Load(object sender, EventArgs e)
        {
            if (P == "1")       // p == "1"  为注册新用户功能
            {
                注册用户panel.Visible = true;
                注销用户panel.Visible = false;
            }
            else if (P == "2")  // p == "2"  为注销用户功能
            {
            }
            else                //          为修改个人信息
            {
                注册用户panel.Visible = false;
                注销用户panel.Visible = false ;
                string str = System.Configuration.ConfigurationManager.ConnectionStrings["library"].ConnectionString;
                string sql;
                if (_Tag == "user")
                {
                    sql = "select * from users where uId='" + Id + "'";
                }
                else
                {
                    sql = "select * from admin where aId='" + Id + "'";
                }
                using (SqlConnection conn = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    // ExecuteReader()返回一个Datareader对象，这个对象的内容就是与命令匹配的所有行
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        r.Read();
                        账号textBox.Text = r.GetString(0);
                        姓名textBox.Text = r.GetString(2);
                        电话号码textBox.Text = r.GetString(4);
                        if (_Tag == "user")
                        {
                            if (r.GetString(5) == "1")
                            {
                                label7.Text = "被锁定,请尽快联系管理员办理解锁";
                            }
                            else
                            {
                                label7.Text = "正常";
                            }
                        }
                        else
                        {
                            label7.Text = "正常";
                        }

                        if (r.GetString(3) == "男")
                        {
                            男radioButton.Checked = true;
                        }
                        else
                        {
                            女radioButton.Checked = true;
                        }
                    }
                    cmd.Dispose();
                }
                提交button.Visible = false;
            }
        }


        #region 提交修改个人信息  
        private void 姓名textBox_TextChanged(object sender, EventArgs e)
        {
            提交button.Visible = true;
        }
        private void 账号textBox_TextChanged(object sender, EventArgs e)
        {
            if (账号textBox.Text!= Id)
            {
                提交button.Visible = true;
            }
            else
            {
                提交button.Visible = false;
            }
        }
        private void 男radioButton_CheckedChanged(object sender, EventArgs e)
        {
            提交button.Visible = true;
        }
        private void 电话号码textBox_TextChanged(object sender, EventArgs e)
        {
            提交button.Visible = true;
        }

        private void 提交button_Click(object sender, EventArgs e)
        { 
            // 判断账号是否存在
            if (账号textBox.Text != Id)
            {
                if (SqlHelper.IsUserExists(uIdTb.Text.Trim()))
                {
                    MessageBox.Show("账号已存在", "操作失败");
                    return;
                }
            }

            // 完成用户的修改
            string uName = 姓名textBox.Text.Trim();
            string uId = 账号textBox.Text.Trim();
            string uPhoNum = 电话号码textBox.Text.Trim();
            string uGender;
            if (男radioButton.Checked == true)
            {
                uGender = "男";
            }
            else
            {
                uGender = "女";
            }
            // 构造sql语句
            string sql;
            if (_Tag == "user")
            {
                sql = "update users set uId =@uId,uName=@uName,uGender=@uGender,uPhoNum=@uPhoNum where uId=@ID";
            }
            else
            {
                sql = "update admin set aId =@uId,aName=@uName,aGender=@uGender,aPhoNum=@uPhoNum where aId=@ID";
            }
            MyDictionary dic = new MyDictionary();
            dic.Add("@uId", uId);
            dic.Add("@uName", uName);
            dic.Add("@uGender", uGender);
            dic.Add("@uPhoNum", uPhoNum);
            dic.Add("@ID", Id);
            // 执行并返回
            int i = SqlHelper.ExecuteNonQuery(sql, dic);

            if (i == 1)
            {
                MessageBox.Show("提交完成");
            }
            this.Close();

        }       
        #endregion


        private void 注册完成button_Click(object sender, EventArgs e)
        {
            string uGender = "";
            if (uIdTb.Text.Trim().Length < 6)
            {
                MessageBox.Show("账号长度应该大于6");
            }
            else if (uPwdTb.Text.Trim().Length < 6)
            {
                MessageBox.Show("密码长度应该大于6");
            }
            else if (uNameTb.Text.Trim().Length < 2 || uNameTb.Text.Trim().Length > 15)
            {
                MessageBox.Show("姓名长度应该大于1并且小于等于15");
            }
            else if (注册rBtn男.Checked == false && 注册rBtn女.Checked == false)
            {
                MessageBox.Show("请选择性别");
            }
            else if (Regex.IsMatch(uPhoNumTb.Text.Trim(), @"^1\d{10}$") != true && Regex.IsMatch(uPhoNumTb.Text.Trim(), @"^(\d{3,4}-)?\d{6,8}$") != true)
            {
                MessageBox.Show("请输入合法的手机号码或电话号码");
            }
            else
            {
                // 判断判断账号是否存在
                if (SqlHelper.IsUserExists(uIdTb.Text.Trim()))
                {
                    MessageBox.Show("账号已存在","操作失败");
                    return;
                }
                
                if(注册rBtn男.Checked == true )
                {
                    uGender ="男";
                }
                else 
                {
                    uGender ="女";
                }

                // 添加新用户
                string sql = "insert into users(uId,uPwd,uName,uGender,uPhoNum,uBan) values(@id,@pwd,@name,@gender,@phonum,'0')";
                MyDictionary  dic = new MyDictionary ();
                dic.Add("@id", uIdTb.Text.Trim());
                dic.Add("@pwd", uPwdTb.Text.Trim());
                dic.Add("@name", uNameTb.Text.Trim());
                dic.Add("@gender", uGender);
                dic.Add("@phonum", uPhoNumTb.Text.Trim());
                int i = SqlHelper.ExecuteNonQuery(sql, dic);
                if (i == 1)
                {
                    MessageBox.Show("成功注册新用户");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("操作失败,请联系管理员");
                }
            }
        }

        private void 注销Btn_Click(object sender, EventArgs e)
        {
            // 判断账号是否存在
            if (!SqlHelper.IsUserExists(deletTB.Text.Trim()))
            {
                MessageBox.Show("账号不存在", "操作失败");
                return;
            }
            else
            {
                DialogResult dt = MessageBox.Show("确定要注销此用户吗", "提示", MessageBoxButtons.OKCancel);
                if (dt != DialogResult.OK)
                {
                    return;
                }
                else
                {
                    string sql = "delete from users where uId=@id";
                    MyDictionary dic = new MyDictionary();
                    dic.Add("@id", deletTB.Text.Trim());
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
