namespace 图书管理系统
{
    partial class FindBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindBookForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.书籍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新书入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销书籍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.跳转到首页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.前一页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.后一页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.跳转到最后一页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.书籍入库tSBtn = new System.Windows.Forms.ToolStripButton();
            this.保存修改tSBtn = new System.Windows.Forms.ToolStripButton();
            this.刷新书库tSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.跳转至首页tSBtn = new System.Windows.Forms.ToolStripButton();
            this.跳转至上一页tSBtn = new System.Windows.Forms.ToolStripButton();
            this.跳转至下一页页tSBtn = new System.Windows.Forms.ToolStripButton();
            this.跳转至最后一页tSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.按书名查找tSBtn = new System.Windows.Forms.ToolStripButton();
            this.书名tSTB = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.查看帮助tSBtn = new System.Windows.Forms.ToolStripButton();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.图书序列号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.书名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作者 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版社 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.库存数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.书籍ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 书籍ToolStripMenuItem
            // 
            this.书籍ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新书入库ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.刷新ToolStripMenuItem,
            this.注销书籍ToolStripMenuItem});
            this.书籍ToolStripMenuItem.Name = "书籍ToolStripMenuItem";
            this.书籍ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.书籍ToolStripMenuItem.Text = "书籍(B)";
            // 
            // 新书入库ToolStripMenuItem
            // 
            this.新书入库ToolStripMenuItem.Name = "新书入库ToolStripMenuItem";
            this.新书入库ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新书入库ToolStripMenuItem.Text = "书籍入库";
            this.新书入库ToolStripMenuItem.Click += new System.EventHandler(this.新书入库ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改ToolStripMenuItem.Text = "保存修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // 注销书籍ToolStripMenuItem
            // 
            this.注销书籍ToolStripMenuItem.Name = "注销书籍ToolStripMenuItem";
            this.注销书籍ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.注销书籍ToolStripMenuItem.Text = "注销书籍";
            this.注销书籍ToolStripMenuItem.Click += new System.EventHandler(this.注销书籍ToolStripMenuItem_Click);
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.跳转到首页ToolStripMenuItem,
            this.前一页ToolStripMenuItem,
            this.后一页ToolStripMenuItem,
            this.跳转到最后一页ToolStripMenuItem});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.视图ToolStripMenuItem.Text = "视图(V)";
            // 
            // 跳转到首页ToolStripMenuItem
            // 
            this.跳转到首页ToolStripMenuItem.Name = "跳转到首页ToolStripMenuItem";
            this.跳转到首页ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.跳转到首页ToolStripMenuItem.Text = "跳转到首页";
            // 
            // 前一页ToolStripMenuItem
            // 
            this.前一页ToolStripMenuItem.Name = "前一页ToolStripMenuItem";
            this.前一页ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.前一页ToolStripMenuItem.Text = "前一页";
            // 
            // 后一页ToolStripMenuItem
            // 
            this.后一页ToolStripMenuItem.Name = "后一页ToolStripMenuItem";
            this.后一页ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.后一页ToolStripMenuItem.Text = "后一页";
            // 
            // 跳转到最后一页ToolStripMenuItem
            // 
            this.跳转到最后一页ToolStripMenuItem.Name = "跳转到最后一页ToolStripMenuItem";
            this.跳转到最后一页ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.跳转到最后一页ToolStripMenuItem.Text = "跳转到最后一页";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(H)";
            // 
            // 查看帮助ToolStripMenuItem
            // 
            this.查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem";
            this.查看帮助ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.查看帮助ToolStripMenuItem.Text = "查看帮助";
            this.查看帮助ToolStripMenuItem.Click += new System.EventHandler(this.查看帮助ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.书籍入库tSBtn,
            this.保存修改tSBtn,
            this.刷新书库tSBtn,
            this.toolStripSeparator1,
            this.跳转至首页tSBtn,
            this.跳转至上一页tSBtn,
            this.跳转至下一页页tSBtn,
            this.跳转至最后一页tSBtn,
            this.toolStripSeparator2,
            this.按书名查找tSBtn,
            this.书名tSTB,
            this.toolStripLabel1,
            this.查看帮助tSBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(808, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 书籍入库tSBtn
            // 
            this.书籍入库tSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.书籍入库tSBtn.Image = ((System.Drawing.Image)(resources.GetObject("书籍入库tSBtn.Image")));
            this.书籍入库tSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.书籍入库tSBtn.Name = "书籍入库tSBtn";
            this.书籍入库tSBtn.Size = new System.Drawing.Size(36, 36);
            this.书籍入库tSBtn.Text = "书籍入库";
            this.书籍入库tSBtn.Click += new System.EventHandler(this.书籍入库tSBtn_Click);
            // 
            // 保存修改tSBtn
            // 
            this.保存修改tSBtn.AutoSize = false;
            this.保存修改tSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.保存修改tSBtn.Image = ((System.Drawing.Image)(resources.GetObject("保存修改tSBtn.Image")));
            this.保存修改tSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.保存修改tSBtn.Name = "保存修改tSBtn";
            this.保存修改tSBtn.Size = new System.Drawing.Size(33, 32);
            this.保存修改tSBtn.Text = "保存修改";
            this.保存修改tSBtn.Click += new System.EventHandler(this.保存修改tSBtn_Click);
            // 
            // 刷新书库tSBtn
            // 
            this.刷新书库tSBtn.AutoSize = false;
            this.刷新书库tSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.刷新书库tSBtn.Image = ((System.Drawing.Image)(resources.GetObject("刷新书库tSBtn.Image")));
            this.刷新书库tSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.刷新书库tSBtn.Name = "刷新书库tSBtn";
            this.刷新书库tSBtn.Size = new System.Drawing.Size(33, 32);
            this.刷新书库tSBtn.Text = "刷新书库";
            this.刷新书库tSBtn.Click += new System.EventHandler(this.刷新书库tSBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // 跳转至首页tSBtn
            // 
            this.跳转至首页tSBtn.AutoSize = false;
            this.跳转至首页tSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.跳转至首页tSBtn.Image = ((System.Drawing.Image)(resources.GetObject("跳转至首页tSBtn.Image")));
            this.跳转至首页tSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.跳转至首页tSBtn.Name = "跳转至首页tSBtn";
            this.跳转至首页tSBtn.Size = new System.Drawing.Size(33, 32);
            this.跳转至首页tSBtn.Text = "跳转至第一页";
            this.跳转至首页tSBtn.Click += new System.EventHandler(this.跳转至首页tSBtn_Click);
            // 
            // 跳转至上一页tSBtn
            // 
            this.跳转至上一页tSBtn.AutoSize = false;
            this.跳转至上一页tSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.跳转至上一页tSBtn.Image = ((System.Drawing.Image)(resources.GetObject("跳转至上一页tSBtn.Image")));
            this.跳转至上一页tSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.跳转至上一页tSBtn.Name = "跳转至上一页tSBtn";
            this.跳转至上一页tSBtn.Size = new System.Drawing.Size(33, 32);
            this.跳转至上一页tSBtn.Text = "跳转至上一页";
            this.跳转至上一页tSBtn.Click += new System.EventHandler(this.跳转至上一页tSBtn_Click);
            // 
            // 跳转至下一页页tSBtn
            // 
            this.跳转至下一页页tSBtn.AutoSize = false;
            this.跳转至下一页页tSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.跳转至下一页页tSBtn.Image = ((System.Drawing.Image)(resources.GetObject("跳转至下一页页tSBtn.Image")));
            this.跳转至下一页页tSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.跳转至下一页页tSBtn.Name = "跳转至下一页页tSBtn";
            this.跳转至下一页页tSBtn.Size = new System.Drawing.Size(33, 32);
            this.跳转至下一页页tSBtn.Text = "跳转至下一页";
            this.跳转至下一页页tSBtn.Click += new System.EventHandler(this.跳转至下一页页tSBtn_Click);
            // 
            // 跳转至最后一页tSBtn
            // 
            this.跳转至最后一页tSBtn.AutoSize = false;
            this.跳转至最后一页tSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.跳转至最后一页tSBtn.Image = ((System.Drawing.Image)(resources.GetObject("跳转至最后一页tSBtn.Image")));
            this.跳转至最后一页tSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.跳转至最后一页tSBtn.Name = "跳转至最后一页tSBtn";
            this.跳转至最后一页tSBtn.Size = new System.Drawing.Size(33, 32);
            this.跳转至最后一页tSBtn.Text = "跳至最后一页";
            this.跳转至最后一页tSBtn.Click += new System.EventHandler(this.跳转至最后一页tSBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // 按书名查找tSBtn
            // 
            this.按书名查找tSBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.按书名查找tSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.按书名查找tSBtn.Image = ((System.Drawing.Image)(resources.GetObject("按书名查找tSBtn.Image")));
            this.按书名查找tSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.按书名查找tSBtn.Name = "按书名查找tSBtn";
            this.按书名查找tSBtn.Size = new System.Drawing.Size(36, 36);
            this.按书名查找tSBtn.Text = "按书名查找";
            this.按书名查找tSBtn.Click += new System.EventHandler(this.按书名查找tSBtn_Click);
            // 
            // 书名tSTB
            // 
            this.书名tSTB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.书名tSTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.书名tSTB.Name = "书名tSTB";
            this.书名tSTB.Size = new System.Drawing.Size(126, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(107, 36);
            this.toolStripLabel1.Text = "输入书名快速查找:";
            // 
            // 查看帮助tSBtn
            // 
            this.查看帮助tSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.查看帮助tSBtn.Image = ((System.Drawing.Image)(resources.GetObject("查看帮助tSBtn.Image")));
            this.查看帮助tSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.查看帮助tSBtn.Name = "查看帮助tSBtn";
            this.查看帮助tSBtn.Size = new System.Drawing.Size(36, 36);
            this.查看帮助tSBtn.Text = "查看帮助";
            this.查看帮助tSBtn.Click += new System.EventHandler(this.查看帮助tSBtn_Click);
            // 
            // dgv_list
            // 
            this.dgv_list.AllowUserToAddRows = false;
            this.dgv_list.AllowUserToResizeColumns = false;
            this.dgv_list.AllowUserToResizeRows = false;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.图书序列号,
            this.书名,
            this.作者,
            this.出版社,
            this.出版日期,
            this.ISBN,
            this.价格,
            this.库存数量});
            this.dgv_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_list.Location = new System.Drawing.Point(0, 64);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.RowTemplate.Height = 23;
            this.dgv_list.Size = new System.Drawing.Size(808, 347);
            this.dgv_list.TabIndex = 2;
            // 
            // 图书序列号
            // 
            this.图书序列号.DataPropertyName = "bNum";
            this.图书序列号.HeaderText = "图书序列号";
            this.图书序列号.Name = "图书序列号";
            this.图书序列号.ReadOnly = true;
            this.图书序列号.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.图书序列号.Width = 90;
            // 
            // 书名
            // 
            this.书名.DataPropertyName = "bName";
            this.书名.HeaderText = "书名";
            this.书名.Name = "书名";
            this.书名.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.书名.Width = 140;
            // 
            // 作者
            // 
            this.作者.DataPropertyName = "bAuthor";
            this.作者.HeaderText = "作者";
            this.作者.Name = "作者";
            this.作者.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // 出版社
            // 
            this.出版社.DataPropertyName = "bPubCom";
            this.出版社.HeaderText = "出版社";
            this.出版社.Name = "出版社";
            this.出版社.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // 出版日期
            // 
            this.出版日期.DataPropertyName = "bPubDat";
            this.出版日期.HeaderText = "出版日期";
            this.出版日期.Name = "出版日期";
            this.出版日期.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.出版日期.Width = 80;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ISBN.Width = 120;
            // 
            // 价格
            // 
            this.价格.DataPropertyName = "bPrice";
            this.价格.HeaderText = "价格";
            this.价格.Name = "价格";
            this.价格.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.价格.Width = 55;
            // 
            // 库存数量
            // 
            this.库存数量.DataPropertyName = "bTag";
            this.库存数量.HeaderText = "库存数量";
            this.库存数量.Name = "库存数量";
            this.库存数量.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.库存数量.Width = 80;
            // 
            // FindBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 411);
            this.Controls.Add(this.dgv_list);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FindBookForm";
            this.Text = "书籍查询";
            this.Load += new System.EventHandler(this.FindBookForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem 书籍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新书入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销书籍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 跳转到首页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 前一页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 后一页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 跳转到最后一页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton 保存修改tSBtn;
        private System.Windows.Forms.ToolStripButton 跳转至首页tSBtn;
        private System.Windows.Forms.ToolStripButton 跳转至最后一页tSBtn;
        private System.Windows.Forms.ToolStripButton 跳转至上一页tSBtn;
        private System.Windows.Forms.ToolStripButton 跳转至下一页页tSBtn;
        private System.Windows.Forms.ToolStripButton 刷新书库tSBtn;
        private System.Windows.Forms.ToolStripButton 书籍入库tSBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton 按书名查找tSBtn;
        private System.Windows.Forms.ToolStripTextBox 书名tSTB;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.ToolStripButton 查看帮助tSBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 图书序列号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 书名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作者;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出版社;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出版日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn 价格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 库存数量;
    }
}