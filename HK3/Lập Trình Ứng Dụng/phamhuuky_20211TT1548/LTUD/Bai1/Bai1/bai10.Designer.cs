
namespace Bai10
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtnI = new System.Windows.Forms.RadioButton();
            this.rbtnII = new System.Windows.Forms.RadioButton();
            this.rbtnIII = new System.Windows.Forms.RadioButton();
            this.rbtnIV = new System.Windows.Forms.RadioButton();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ckListBoxS = new System.Windows.Forms.CheckedListBox();
            this.cbSyear = new System.Windows.Forms.ComboBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(243, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng Ký Môn Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSSV : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Niên Khóa :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lớp : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Học Kỳ :";            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Môn Học :";
            // 
            // rbtnI
            // 
            this.rbtnI.AutoSize = true;
            this.rbtnI.Location = new System.Drawing.Point(250, 323);
            this.rbtnI.Name = "rbtnI";
            this.rbtnI.Size = new System.Drawing.Size(32, 21);
            this.rbtnI.TabIndex = 8;
            this.rbtnI.TabStop = true;
            this.rbtnI.Text = "I";
            this.rbtnI.UseVisualStyleBackColor = true;
            this.rbtnI.CheckedChanged += new System.EventHandler(this.rbtnI_CheckedChanged);
            // 
            // rbtnII
            // 
            this.rbtnII.AutoSize = true;
            this.rbtnII.Location = new System.Drawing.Point(332, 323);
            this.rbtnII.Name = "rbtnII";
            this.rbtnII.Size = new System.Drawing.Size(35, 21);
            this.rbtnII.TabIndex = 9;
            this.rbtnII.TabStop = true;
            this.rbtnII.Text = "II";
            this.rbtnII.UseVisualStyleBackColor = true;
            this.rbtnII.CheckedChanged += new System.EventHandler(this.rbtnII_CheckedChanged);
            // 
            // rbtnIII
            // 
            this.rbtnIII.AutoSize = true;
            this.rbtnIII.Location = new System.Drawing.Point(419, 323);
            this.rbtnIII.Name = "rbtnIII";
            this.rbtnIII.Size = new System.Drawing.Size(38, 21);
            this.rbtnIII.TabIndex = 10;
            this.rbtnIII.TabStop = true;
            this.rbtnIII.Text = "III";
            this.rbtnIII.UseVisualStyleBackColor = true;
            this.rbtnIII.CheckedChanged += new System.EventHandler(this.rbtnIII_CheckedChanged);
            // 
            // rbtnIV
            // 
            this.rbtnIV.AutoSize = true;
            this.rbtnIV.Location = new System.Drawing.Point(515, 323);
            this.rbtnIV.Name = "rbtnIV";
            this.rbtnIV.Size = new System.Drawing.Size(41, 21);
            this.rbtnIV.TabIndex = 11;
            this.rbtnIV.TabStop = true;
            this.rbtnIV.Text = "IV";
            this.rbtnIV.UseVisualStyleBackColor = true;
            this.rbtnIV.CheckedChanged += new System.EventHandler(this.rbtnIV_CheckedChanged);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(237, 140);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(319, 22);
            this.txtMSSV.TabIndex = 12;
            this.txtMSSV.Enter += new System.EventHandler(this.txtMSSV_Enter);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(237, 188);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(319, 22);
            this.txtName.TabIndex = 13;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(207, 487);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(75, 43);
            this.btnSign.TabIndex = 16;
            this.btnSign.Text = "Dăng ký";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(344, 487);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 43);
            this.btnAbort.TabIndex = 17;
            this.btnAbort.Text = "Hủy ";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(481, 487);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 43);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ckListBoxS
            // 
            this.ckListBoxS.FormattingEnabled = true;
            this.ckListBoxS.Items.AddRange(new object[] {
            "LT Windows",
            "LT Internet",
            "Mang May Tinh",
            "UMl"});
            this.ckListBoxS.Location = new System.Drawing.Point(237, 373);
            this.ckListBoxS.Name = "ckListBoxS";
            this.ckListBoxS.Size = new System.Drawing.Size(319, 89);
            this.ckListBoxS.TabIndex = 19;
            this.ckListBoxS.SelectedIndexChanged += new System.EventHandler(this.ckListBoxS_SelectedIndexChanged);
            // 
            // cbSyear
            // 
            this.cbSyear.FormattingEnabled = true;
            this.cbSyear.Items.AddRange(new object[] {
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008"});
            this.cbSyear.Location = new System.Drawing.Point(237, 236);
            this.cbSyear.Name = "cbSyear";
            this.cbSyear.Size = new System.Drawing.Size(319, 24);
            this.cbSyear.TabIndex = 20;
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Items.AddRange(new object[] {
            "CD2001",
            "CD2002",
            "CD2003",
            "CD2004",
            "CD2005",
            "CD2006",
            "CD2007",
            "CD2008",
            "CD2009"});
            this.cbClass.Location = new System.Drawing.Point(237, 280);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(319, 24);
            this.cbClass.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 542);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.cbSyear);
            this.Controls.Add(this.ckListBoxS);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.rbtnIV);
            this.Controls.Add(this.rbtnIII);
            this.Controls.Add(this.rbtnII);
            this.Controls.Add(this.rbtnI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtnI;
        private System.Windows.Forms.RadioButton rbtnII;
        private System.Windows.Forms.RadioButton rbtnIII;
        private System.Windows.Forms.RadioButton rbtnIV;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckedListBox ckListBoxS;
        private System.Windows.Forms.ComboBox cbSyear;
        private System.Windows.Forms.ComboBox cbClass;
    }
}

