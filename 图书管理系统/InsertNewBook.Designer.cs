namespace 图书管理系统
{
    partial class 新书入库Form
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
            this.新书入库Btn = new System.Windows.Forms.Button();
            this.bNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bAuthorTB = new System.Windows.Forms.TextBox();
            this.bPubComTB = new System.Windows.Forms.TextBox();
            this.bPubDatTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.bPriceTB = new System.Windows.Forms.TextBox();
            this.bTagTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.书籍注销panel = new System.Windows.Forms.Panel();
            this.注销书籍TB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.注销书籍Btn = new System.Windows.Forms.Button();
            this.书籍注销panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // 新书入库Btn
            // 
            this.新书入库Btn.Location = new System.Drawing.Point(216, 277);
            this.新书入库Btn.Name = "新书入库Btn";
            this.新书入库Btn.Size = new System.Drawing.Size(75, 23);
            this.新书入库Btn.TabIndex = 0;
            this.新书入库Btn.Text = "完成";
            this.新书入库Btn.UseVisualStyleBackColor = true;
            this.新书入库Btn.Click += new System.EventHandler(this.新书入库Btn_Click);
            // 
            // bNameTB
            // 
            this.bNameTB.Location = new System.Drawing.Point(127, 45);
            this.bNameTB.Name = "bNameTB";
            this.bNameTB.Size = new System.Drawing.Size(122, 21);
            this.bNameTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "书名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "作者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "出版社：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "出版年月：";
            // 
            // bAuthorTB
            // 
            this.bAuthorTB.Location = new System.Drawing.Point(341, 45);
            this.bAuthorTB.Name = "bAuthorTB";
            this.bAuthorTB.Size = new System.Drawing.Size(124, 21);
            this.bAuthorTB.TabIndex = 6;
            // 
            // bPubComTB
            // 
            this.bPubComTB.Location = new System.Drawing.Point(127, 95);
            this.bPubComTB.Name = "bPubComTB";
            this.bPubComTB.Size = new System.Drawing.Size(122, 21);
            this.bPubComTB.TabIndex = 7;
            // 
            // bPubDatTB
            // 
            this.bPubDatTB.Location = new System.Drawing.Point(127, 201);
            this.bPubDatTB.Name = "bPubDatTB";
            this.bPubDatTB.Size = new System.Drawing.Size(122, 21);
            this.bPubDatTB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "价格：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "ISBN：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "数量：";
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(341, 95);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(122, 21);
            this.ISBN.TabIndex = 12;
            // 
            // bPriceTB
            // 
            this.bPriceTB.Location = new System.Drawing.Point(341, 148);
            this.bPriceTB.Name = "bPriceTB";
            this.bPriceTB.Size = new System.Drawing.Size(124, 21);
            this.bPriceTB.TabIndex = 13;
            // 
            // bTagTB
            // 
            this.bTagTB.Location = new System.Drawing.Point(127, 148);
            this.bTagTB.Name = "bTagTB";
            this.bTagTB.Size = new System.Drawing.Size(122, 21);
            this.bTagTB.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "（格式 yyyy-mm）";
            // 
            // 书籍注销panel
            // 
            this.书籍注销panel.Controls.Add(this.注销书籍TB);
            this.书籍注销panel.Controls.Add(this.label9);
            this.书籍注销panel.Controls.Add(this.注销书籍Btn);
            this.书籍注销panel.Location = new System.Drawing.Point(21, 29);
            this.书籍注销panel.Name = "书籍注销panel";
            this.书籍注销panel.Size = new System.Drawing.Size(487, 271);
            this.书籍注销panel.TabIndex = 16;
            // 
            // 注销书籍TB
            // 
            this.注销书籍TB.Location = new System.Drawing.Point(236, 92);
            this.注销书籍TB.Name = "注销书籍TB";
            this.注销书籍TB.Size = new System.Drawing.Size(135, 21);
            this.注销书籍TB.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "请输入书籍序列号：";
            // 
            // 注销书籍Btn
            // 
            this.注销书籍Btn.Location = new System.Drawing.Point(195, 172);
            this.注销书籍Btn.Name = "注销书籍Btn";
            this.注销书籍Btn.Size = new System.Drawing.Size(75, 23);
            this.注销书籍Btn.TabIndex = 0;
            this.注销书籍Btn.Text = "注销书籍";
            this.注销书籍Btn.UseVisualStyleBackColor = true;
            this.注销书籍Btn.Click += new System.EventHandler(this.注销书籍Btn_Click);
            // 
            // 新书入库Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 334);
            this.Controls.Add(this.书籍注销panel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bTagTB);
            this.Controls.Add(this.bPriceTB);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bPubDatTB);
            this.Controls.Add(this.bPubComTB);
            this.Controls.Add(this.bAuthorTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bNameTB);
            this.Controls.Add(this.新书入库Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "新书入库Form";
            this.Text = "新书入库";
            this.Load += new System.EventHandler(this.新书入库Form_Load);
            this.书籍注销panel.ResumeLayout(false);
            this.书籍注销panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 新书入库Btn;
        private System.Windows.Forms.TextBox bNameTB;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bAuthorTB;
        private System.Windows.Forms.TextBox bPubComTB;
        private System.Windows.Forms.TextBox bPubDatTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.TextBox bPriceTB;
        private System.Windows.Forms.TextBox bTagTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel 书籍注销panel;
        private System.Windows.Forms.TextBox 注销书籍TB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button 注销书籍Btn;
    }
}