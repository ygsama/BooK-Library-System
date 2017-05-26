namespace 图书管理系统
{
    partial class ReturnBooks
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
            this.uIdTB = new System.Windows.Forms.TextBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDDTB = new System.Windows.Forms.TextBox();
            this.bNameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bNumTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uuIdTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.borrowDateTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.returnDateTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bPriceTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TagTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uIdTB
            // 
            this.uIdTB.Location = new System.Drawing.Point(283, 23);
            this.uIdTB.Name = "uIdTB";
            this.uIdTB.Size = new System.Drawing.Size(173, 21);
            this.uIdTB.TabIndex = 0;
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(480, 21);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(161, 23);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "提交";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(842, 452);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -2;
            this.lineShape1.X2 = 842;
            this.lineShape1.Y1 = 57;
            this.lineShape1.Y2 = 57;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.uId,
            this.bNum,
            this.bName,
            this.bPrice,
            this.borrowDate,
            this.returnDate,
            this.Tag});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 200);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(844, 252);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "借书单号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // uId
            // 
            this.uId.DataPropertyName = "uId";
            this.uId.HeaderText = "用户账号";
            this.uId.Name = "uId";
            this.uId.ReadOnly = true;
            // 
            // bNum
            // 
            this.bNum.DataPropertyName = "bNum";
            this.bNum.HeaderText = "书籍序列号";
            this.bNum.Name = "bNum";
            this.bNum.ReadOnly = true;
            // 
            // bName
            // 
            this.bName.DataPropertyName = "bName";
            this.bName.HeaderText = "书名";
            this.bName.Name = "bName";
            this.bName.ReadOnly = true;
            // 
            // bPrice
            // 
            this.bPrice.DataPropertyName = "bPrice";
            this.bPrice.HeaderText = "价格";
            this.bPrice.Name = "bPrice";
            this.bPrice.ReadOnly = true;
            // 
            // borrowDate
            // 
            this.borrowDate.DataPropertyName = "borrowDate";
            this.borrowDate.HeaderText = "借出日期";
            this.borrowDate.Name = "borrowDate";
            this.borrowDate.ReadOnly = true;
            // 
            // returnDate
            // 
            this.returnDate.DataPropertyName = "returnDate";
            this.returnDate.HeaderText = "归还日期";
            this.returnDate.Name = "returnDate";
            this.returnDate.ReadOnly = true;
            // 
            // Tag
            // 
            this.Tag.DataPropertyName = "Tag";
            this.Tag.HeaderText = "是否逾期";
            this.Tag.Name = "Tag";
            this.Tag.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "第一步 =>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "第二步 =>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "输入账号，查询借书单:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "借书单号：";
            // 
            // IDDTB
            // 
            this.IDDTB.Location = new System.Drawing.Point(177, 85);
            this.IDDTB.Name = "IDDTB";
            this.IDDTB.Size = new System.Drawing.Size(116, 21);
            this.IDDTB.TabIndex = 8;
            // 
            // bNameTB
            // 
            this.bNameTB.Location = new System.Drawing.Point(393, 85);
            this.bNameTB.Name = "bNameTB";
            this.bNameTB.Size = new System.Drawing.Size(120, 21);
            this.bNameTB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "书籍序列号：";
            // 
            // bNumTB
            // 
            this.bNumTB.Location = new System.Drawing.Point(393, 122);
            this.bNumTB.Name = "bNumTB";
            this.bNumTB.Size = new System.Drawing.Size(120, 21);
            this.bNumTB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "书名：";
            // 
            // uuIdTB
            // 
            this.uuIdTB.Location = new System.Drawing.Point(178, 122);
            this.uuIdTB.Name = "uuIdTB";
            this.uuIdTB.Size = new System.Drawing.Size(115, 21);
            this.uuIdTB.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "用户账号：";
            // 
            // borrowDateTB
            // 
            this.borrowDateTB.Location = new System.Drawing.Point(614, 82);
            this.borrowDateTB.Name = "borrowDateTB";
            this.borrowDateTB.Size = new System.Drawing.Size(124, 21);
            this.borrowDateTB.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "借出日期：";
            // 
            // returnDateTB
            // 
            this.returnDateTB.Location = new System.Drawing.Point(614, 119);
            this.returnDateTB.Name = "returnDateTB";
            this.returnDateTB.Size = new System.Drawing.Size(124, 21);
            this.returnDateTB.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(543, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "归还日期：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 22);
            this.button1.TabIndex = 19;
            this.button1.Text = "点击单元格，提交还书";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bPriceTB
            // 
            this.bPriceTB.Location = new System.Drawing.Point(393, 159);
            this.bPriceTB.Name = "bPriceTB";
            this.bPriceTB.Size = new System.Drawing.Size(120, 21);
            this.bPriceTB.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(324, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "书籍价格：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(107, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "是否逾期：";
            // 
            // TagTB
            // 
            this.TagTB.Location = new System.Drawing.Point(178, 159);
            this.TagTB.Name = "TagTB";
            this.TagTB.Size = new System.Drawing.Size(115, 21);
            this.TagTB.TabIndex = 23;
            // 
            // ReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 452);
            this.Controls.Add(this.TagTB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bPriceTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.borrowDateTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.returnDateTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uuIdTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bNumTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bNameTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IDDTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.uIdTB);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReturnBooks";
            this.Text = "还书办理";
            this.Load += new System.EventHandler(this.ReturnBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uIdTB;
        private System.Windows.Forms.Button Btn1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn uId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn bName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDDTB;
        private System.Windows.Forms.TextBox bNameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bNumTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uuIdTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox borrowDateTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox returnDateTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bPriceTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TagTB;
    }
}