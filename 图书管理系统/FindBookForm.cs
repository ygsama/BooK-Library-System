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
    public partial class FindBookForm : Form
    {
        public FindBookForm()
        {
            InitializeComponent();
        }
        private string _tag;
        public string Tag1
        {
            get { return _tag; }
            set { _tag = value; }
        }

        // pageIndex 标记DGV应该显示第几页
        private int pageIndex;
        // pageIndex 标记DGV的总页数
        int maxIndex;

        #region 添加书籍
        private static void INB()
        {
            新书入库Form iNB = new 新书入库Form();
            iNB.ShowDialog();
        }
        private void 新书入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            INB();
        }
        private void 书籍入库tSBtn_Click(object sender, EventArgs e)
        {
            INB();
        }

        #endregion

        #region 注销书籍
        private void 注销书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            新书入库Form iNB = new 新书入库Form();
            iNB.P = "1";
            iNB.Text = "注销书籍";
            iNB.ShowDialog();
        }
        #endregion

        #region 查看帮助
        private void 查看帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系管理员", "帮助");
        }
        private void 查看帮助tSBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系管理员", "帮助");
        }

        #endregion

        private void FindBookForm_Load(object sender, EventArgs e)
        {
            if (Tag1 == "user")
            {
                注销书籍ToolStripMenuItem.Enabled = false;
                修改ToolStripMenuItem.Enabled = false;
                新书入库ToolStripMenuItem.Enabled = false;
                书籍入库tSBtn.Enabled = false;
                保存修改tSBtn.Enabled = false;
                dgv_list.ReadOnly = true;
            }
            pageIndex = 1;
            GetData();
        }

        private void GetData()
        {
            // 获取页大小
            int pageSize = 14;
            // 计算最多有多少页--Math.Ceiling--向上取整
            // Convert.ToInt32(SqlHelper.ExecuteScalar("select count(*) from books"))得到数据记录总数
            maxIndex = (int)Math.Ceiling((Convert.ToInt32(SqlHelper.ExecuteScalar("select count(*) from books")) * 1.0 / pageSize));
            // 获取连接字符串
            string str = System.Configuration.ConfigurationManager.ConnectionStrings["library"].ConnectionString;
            // 得到连接
            using (SqlConnection conn = new SqlConnection(str))
            {
                // 判断是否有数据
                // Convert.ToInt32(SqlHelper.ExecuteScalar("select count(*) from books"))得到数据记录总数
                if (Convert .ToInt32 (SqlHelper.ExecuteScalar("select count(*) from books")) > 0 && pageIndex > 0)
                {
                    // 确定有数据才进行查询
                    // 创建表格，用来存储数据
                    DataTable dt = new DataTable();
                    // 构造带分页功能的 sql 语句
                    string sql = "select bNum,bName,bAuthor,bPubCom,bPubDat,ISBN,bPrice,bTag from booksWithbookindex where bookindex between @sIndex and @eIndex";
                    // 构造适配器对象
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    // 传递参数
                    // 本页第一条数据
                    adapter.SelectCommand.Parameters.AddWithValue("@sIndex", ((pageIndex - 1) * pageSize + 1));
                    // 本页最后一条数据
                    adapter.SelectCommand.Parameters.AddWithValue("@eIndex", pageIndex * pageSize);
                    // 执行查询
                    conn.Open();
                    adapter.Fill(dt);
                    dgv_list.DataSource = dt;
                }
                else if (pageIndex <= 0)
                {
                    pageIndex = 1;
                }
                else
                {
                    MessageBox.Show("没有获取到数据","警告");
                }
            }
        }

        private void 刷新书库tSBtn_Click(object sender, EventArgs e)
        {
            if (pageIndex <= 0)
            {
                pageIndex = 1;
            }
            GetData();
        }
        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pageIndex <= 0)
            {
                pageIndex = 1;
            }
            GetData();
        }

        private void 跳转至首页tSBtn_Click(object sender, EventArgs e)
        {
            pageIndex = 1;
            GetData();
        }

        private void 跳转至上一页tSBtn_Click(object sender, EventArgs e)
        {
            pageIndex--;
            if (pageIndex <= 0)
            {
                pageIndex = 1;
            }
            GetData();
        }

        private void 跳转至下一页页tSBtn_Click(object sender, EventArgs e)
        {
            pageIndex++;
            if (pageIndex > maxIndex )
            {
                pageIndex--;
                MessageBox.Show("哎呀，到底啦 ！","提示");
            }
            GetData();
        }

        private void 跳转至最后一页tSBtn_Click(object sender, EventArgs e)
        {
            pageIndex = maxIndex;
            GetData();
        }

        private void 保存修改tSBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能暂未开放");
            /*
             * 
             * 
            // 若绑定数据源则用dgv_list.DataSource as DataTable;
            // 未绑定则用DgvToTable()强制转换
            // = DgvToTable(dgv_list);
            DataTable dt=dgv_list.DataSource as DataTable;
            // 完成adapter的UpdateCommand
            string str = System.Configuration.ConfigurationManager.ConnectionStrings["library"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(str))
            {

                SqlDataAdapter adapter = new SqlDataAdapter();

                // 构造UpdateCommand
                string update = "update books set bName=@bName, bAuthor=@bAuthor,bPubCom=@bPubCom,bPubDat=@bPubDat,ISBN=@ISBN,bPrice=@bPrice,bTag=@bTag where bNum=@bNum";
                SqlCommand updateCmd = new SqlCommand(update, conn);
                updateCmd.Parameters.Add("@bName", SqlDbType.NVarChar , 60, "bName");
                updateCmd.Parameters.Add("@bAuthor", SqlDbType.NVarChar, 60, "bAuthor");
                updateCmd.Parameters.Add("@bPubCom", SqlDbType.NVarChar, 50, "bPubCom");
                updateCmd.Parameters.Add("@bPubDat", SqlDbType.NVarChar, 20, "bPubDat");
                updateCmd.Parameters.Add("@ISBN", SqlDbType.NVarChar, 50, "ISBN");
                updateCmd.Parameters.Add("@bPrice", SqlDbType.NVarChar, 10, "bPrice");
                updateCmd.Parameters.Add("@bTag", SqlDbType.NVarChar, 10, "bTag");
                updateCmd.Parameters.Add("@bNum", SqlDbType.NVarChar, 10, "bNum");
                adapter.UpdateCommand = updateCmd;

                // 执行
                conn.Open();
                adapter.Update(dt);
            }

            // 刷新数据
            GetData();
            MessageBox.Show("保存成功");
            *
            *
            */
        }
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能暂未开放");
        }

        private void 按书名查找tSBtn_Click(object sender, EventArgs e)
        {
            string sql = "select bNum,bName,bAuthor,bPubCom,bPubDat,ISBN,bPrice,bTag from booksWithbookindex where bName like '%'+ @bName +'%'";
            MyDictionary dic = new MyDictionary();
            dic.Add("@bName", 书名tSTB.Text.Trim());
            DataTable dt = SqlHelper.GetList(sql, dic);
            dgv_list.DataSource = dt;
        }
    }
}
