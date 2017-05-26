using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 图书管理系统
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
             // 获取账号
             string Id = txtId.Text.Trim();
             // 获取密码
             string Pwd = txtPwd.Text.Trim();

             if (Id == "" || Pwd == "")
             {
                 MessageBox.Show("请输入账号或密码");
             }
             else 
             {
                 string str = System.Configuration.ConfigurationManager.ConnectionStrings["library"].ConnectionString;
                 // 构造sql查询语句
                 string sql;
                 if (rBtn1.Checked == true)
                 {
                     sql = "select uName from users where uId='" + Id + "' and uPwd='" + Pwd + "'";
                 }
                 else 
                 {
                     sql = "select aName from admin where aId='" + Id + "' and aPwd='" + Pwd + "'";
                 }
                 // 构造连接对象
                 using (SqlConnection conn = new SqlConnection(str))       
                 {
                     SqlCommand cmd = new SqlCommand(sql, conn);
                     // 打开数据库连接
                     conn.Open();                                          
                     // 执行查询语句,返回结果集第一行第一列
                     string name = cmd.ExecuteScalar().ToString ();       
                     
                     if (name != "")
                     {
                         // 登录窗体隐藏
                         this.Hide();
                         // 创建主窗体
                         MainForm mainForm = new MainForm();
                         // 将账号传给主窗体MainForm
                         mainForm.Id = Id;
                         // 用主窗体MainForm下的_Tag标记登陆的是用户还是管理员
                         if (rBtn1.Checked == true)                   
                         {
                             mainForm._Tag = "user";
                             mainForm.Name1 = name;

                             sql = "select uBan from users where uId='" + Id + "' and uPwd='" + Pwd + "'";
                             cmd = new SqlCommand(sql, conn);
                             string b = cmd.ExecuteScalar().ToString();
                             mainForm.B = b;
                         }
                         else
                         {
                             mainForm._Tag = "admin";
                             mainForm.Name1 = name;
                         }
                         // 显示主窗体
                         mainForm.ShowDialog();                         
                     }
                     else 
                     {
                         MessageBox.Show("账号或密码错误！","登录失败");
                     }
                 }
             }
        }
    }
}
