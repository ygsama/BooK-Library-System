using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace 图书管理系统
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string _id;// 账号
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name1 // 姓名
        {
            get { return _name; }
            set { _name = value; }
        }

        // 权限标记 值为admin为管理员 ，值为user则为普通用户
        private string _tag;
        public string _Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }

        // 标记账户是否被锁定  1为锁定 
        private string _b;  
        public string B
        {
            get { return _b; }
            set { _b = value; }
        }

        // 在加载窗体时设定操作权限
        private void MainForm_Load(object sender, EventArgs e)
        {

            if (_Tag == "user")
            {
                tSSL2.Text = "权限级别：普通用户";
                tSSL5.Text = "   " + Name1;

                新用户注册.Enabled = false;
                锁定用户.Enabled = false;
                新书入库.Enabled = false;
                借书.Enabled = false;
                还书.Enabled = false;
                书籍注销.Enabled = false;
                用户信息查询.Enabled = false;
                添加用户.Enabled = false;
                添加书籍.Enabled = false;
                借书办理.Enabled = false;
                还书办理.Enabled = false;

                if (B == "1")
                {
                    toolStripStatusLabel3.Text = " 状态：被锁定";
                    MessageBox.Show("账户被锁定，请尽快联系管理员", "警告");
                }
            }
            else
            {
                tSSL2.Text = "权限级别：管理员";
                tSSL5.Text = "   " + Name1;
            } 
        }

        #region 关于、帮助
        private void 关于软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系管理员", "关于");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系管理员", "注意");
        }
        #endregion

        // 时钟
        private void timer1_Tick(object sender, EventArgs e)
        {
            xxx.Text = DateTime.Now.ToString();
        }

        // 退出时关闭所有窗口（login）
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        #region 修改密码
        private void APF()
        {
            AlterPwdForm altPF = new AlterPwdForm();
            altPF.Id = Id;
            altPF._Tag = _Tag;
            altPF.ShowDialog();
        }
        private void 修改密码_Click(object sender, EventArgs e)
        {
            APF();
        }
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            APF();
        }
        #endregion

        #region 修改个人信息
        private void UIF()
        {
            UpdateIndivForm uIF = new UpdateIndivForm();
            uIF.Id = Id;
            uIF._Tag = _Tag;
            uIF.ShowDialog();
        }
        private void 修改信息_Click(object sender, EventArgs e)
        {
            UIF();
        }
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            UIF();
        }
        #endregion

        #region 添加用户
        private void NewUser()
        {
            UpdateIndivForm uIF = new UpdateIndivForm();
            uIF.Id = Id;
            uIF._Tag = _Tag;
            uIF.P = "1";
            uIF.Text = "新用户注册";
            uIF.ShowDialog();
        }
        private void 添加用户_Click(object sender, EventArgs e)
        {
            NewUser();
        }
        private void 新用户注册_Click(object sender, EventArgs e)
        {
            NewUser();
        }
        #endregion

        #region 注销用户
        private void 注销用户_Click(object sender, EventArgs e)
        {
            UpdateIndivForm deleteForm = new UpdateIndivForm();
            deleteForm.Text = "注销用户";
            deleteForm.P = "2";
            deleteForm.ShowDialog();
        }
        #endregion

        #region 添加书籍
        private static void INB()
        {
            新书入库Form iNB = new 新书入库Form();
            iNB.ShowDialog();
        }
        private void 添加书籍_Click(object sender, EventArgs e)
        {
            INB();
        }
        private void 新书入库_Click(object sender, EventArgs e)
        {
            INB();
        }
        #endregion

        #region 书籍注销
        private void 书籍注销_Click(object sender, EventArgs e)
        {
            新书入库Form iNB = new 新书入库Form();
            iNB.P = "1";
            iNB.Text = "注销书籍";
            iNB.ShowDialog();
        }
        #endregion

        #region 书籍查询
        private void 图书查询_Click(object sender, EventArgs e)
        {
            FindBookForm fbf = new FindBookForm();
            fbf.ShowDialog();
        }

        private void 查找书籍_Click(object sender, EventArgs e)
        {
            FindBookForm fbf = new FindBookForm();
            fbf.Tag1 = this._Tag;
            fbf.ShowDialog();
        }
        #endregion

        #region 借书办理
        private void 借书办理_Click(object sender, EventArgs e)
        {
            BorrowBooks bb = new BorrowBooks();
            bb.ShowDialog();
        }
        private void 借书_Click(object sender, EventArgs e)
        {
            BorrowBooks bb = new BorrowBooks();
            bb.ShowDialog();
        }        
        #endregion

        #region 还书办理
        private void 还书办理_Click(object sender, EventArgs e)
        {
            ReturnBooks rb = new ReturnBooks();
            rb.ShowDialog();
        }
        private void 还书_Click(object sender, EventArgs e)
        {
            ReturnBooks rb = new ReturnBooks();
            rb.ShowDialog();
        }        
        #endregion

        #region 借书单查询
        private void 借书单查询_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能暂未开放");
        }
        private void 查询借书记录_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能暂未开放");
        }        
        #endregion


        private void 用户信息查询_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该功能暂未开放");
        }
    }
}
