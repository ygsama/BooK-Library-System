namespace 图书管理系统
{
    partial class BorrowBooks
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
            this.查书btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPubCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.查寻书名tB = new System.Windows.Forms.TextBox();
            this.bNameTB = new System.Windows.Forms.TextBox();
            this.uIdTb = new System.Windows.Forms.TextBox();
            this.bPriceTB = new System.Windows.Forms.TextBox();
            this.bNumTB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.提交借书 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 查书btn
            // 
            this.查书btn.Location = new System.Drawing.Point(440, 23);
            this.查书btn.Name = "查书btn";
            this.查书btn.Size = new System.Drawing.Size(105, 23);
            this.查书btn.TabIndex = 0;
            this.查书btn.Text = "查询";
            this.查书btn.UseVisualStyleBackColor = true;
            this.查书btn.Click += new System.EventHandler(this.查书btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bNum,
            this.bbName,
            this.bAuthor,
            this.bPubCom,
            this.bPrice,
            this.bTag});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 227);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(644, 165);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            // 
            // bNum
            // 
            this.bNum.DataPropertyName = "bNum";
            this.bNum.HeaderText = "书籍序列号";
            this.bNum.Name = "bNum";
            this.bNum.ReadOnly = true;
            // 
            // bbName
            // 
            this.bbName.DataPropertyName = "bName";
            this.bbName.HeaderText = "书名";
            this.bbName.Name = "bbName";
            this.bbName.ReadOnly = true;
            // 
            // bAuthor
            // 
            this.bAuthor.DataPropertyName = "bAuthor";
            this.bAuthor.HeaderText = "作者";
            this.bAuthor.Name = "bAuthor";
            this.bAuthor.ReadOnly = true;
            // 
            // bPubCom
            // 
            this.bPubCom.DataPropertyName = "bPubCom";
            this.bPubCom.HeaderText = "出版社";
            this.bPubCom.Name = "bPubCom";
            this.bPubCom.ReadOnly = true;
            // 
            // bPrice
            // 
            this.bPrice.DataPropertyName = "bPrice";
            this.bPrice.HeaderText = "价格";
            this.bPrice.Name = "bPrice";
            this.bPrice.ReadOnly = true;
            // 
            // bTag
            // 
            this.bTag.DataPropertyName = "bTag";
            this.bTag.HeaderText = "库存量";
            this.bTag.Name = "bTag";
            this.bTag.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "输入书名点击查询：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "借书用户：";
            // 
            // bName
            // 
            this.bName.AutoSize = true;
            this.bName.Location = new System.Drawing.Point(115, 125);
            this.bName.Name = "bName";
            this.bName.Size = new System.Drawing.Size(41, 12);
            this.bName.TabIndex = 4;
            this.bName.Text = "书名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "书籍序列号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "书籍价格：";
            // 
            // 查寻书名tB
            // 
            this.查寻书名tB.Location = new System.Drawing.Point(234, 25);
            this.查寻书名tB.Name = "查寻书名tB";
            this.查寻书名tB.Size = new System.Drawing.Size(176, 21);
            this.查寻书名tB.TabIndex = 7;
            // 
            // bNameTB
            // 
            this.bNameTB.Location = new System.Drawing.Point(176, 122);
            this.bNameTB.Name = "bNameTB";
            this.bNameTB.ReadOnly = true;
            this.bNameTB.Size = new System.Drawing.Size(131, 21);
            this.bNameTB.TabIndex = 8;
            // 
            // uIdTb
            // 
            this.uIdTb.Location = new System.Drawing.Point(433, 73);
            this.uIdTb.Name = "uIdTb";
            this.uIdTb.Size = new System.Drawing.Size(124, 21);
            this.uIdTb.TabIndex = 9;
            // 
            // bPriceTB
            // 
            this.bPriceTB.Location = new System.Drawing.Point(176, 167);
            this.bPriceTB.Name = "bPriceTB";
            this.bPriceTB.ReadOnly = true;
            this.bPriceTB.Size = new System.Drawing.Size(131, 21);
            this.bPriceTB.TabIndex = 10;
            // 
            // bNumTB
            // 
            this.bNumTB.Location = new System.Drawing.Point(176, 73);
            this.bNumTB.Name = "bNumTB";
            this.bNumTB.ReadOnly = true;
            this.bNumTB.Size = new System.Drawing.Size(131, 21);
            this.bNumTB.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "30天",
            "60天",
            "90天"});
            this.comboBox1.Location = new System.Drawing.Point(436, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "借阅时间：";
            // 
            // 提交借书
            // 
            this.提交借书.Location = new System.Drawing.Point(364, 165);
            this.提交借书.Name = "提交借书";
            this.提交借书.Size = new System.Drawing.Size(197, 23);
            this.提交借书.TabIndex = 14;
            this.提交借书.Text = "请选择书籍,单击并提交";
            this.提交借书.UseVisualStyleBackColor = true;
            this.提交借书.Click += new System.EventHandler(this.提交借书_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "第一步 =>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(3, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "第二步 =>";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(643, 392);
            this.shapeContainer1.TabIndex = 18;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -2;
            this.lineShape1.X2 = 640;
            this.lineShape1.Y1 = 52;
            this.lineShape1.Y2 = 52;
            // 
            // BorrowBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 392);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.提交借书);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bNumTB);
            this.Controls.Add(this.bPriceTB);
            this.Controls.Add(this.uIdTb);
            this.Controls.Add(this.bNameTB);
            this.Controls.Add(this.查寻书名tB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.查书btn);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BorrowBooks";
            this.Text = "借书办理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 查书btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox 查寻书名tB;
        private System.Windows.Forms.TextBox bNameTB;
        private System.Windows.Forms.TextBox uIdTb;
        private System.Windows.Forms.TextBox bPriceTB;
        private System.Windows.Forms.TextBox bNumTB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button 提交借书;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn bbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPubCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn bTag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;

    }
}