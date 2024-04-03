
namespace Bai7
{
    partial class bai7
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
            this.cbNumber = new System.Windows.Forms.ComboBox();
            this.btnNumber = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btntotalwish = new System.Windows.Forms.Button();
            this.btnLuong = new System.Windows.Forms.Button();
            this.btnNguyenTo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNumber);
            this.groupBox1.Controls.Add(this.btnNumber);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Location = new System.Drawing.Point(79, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Số";
            // 
            // cbNumber
            // 
            this.cbNumber.FormattingEnabled = true;
            this.cbNumber.Location = new System.Drawing.Point(6, 99);
            this.cbNumber.Name = "cbNumber";
            this.cbNumber.Size = new System.Drawing.Size(245, 24);
            this.cbNumber.TabIndex = 1;
            // 
            // btnNumber
            // 
            this.btnNumber.Location = new System.Drawing.Point(176, 31);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(81, 44);
            this.btnNumber.TabIndex = 1;
            this.btnNumber.Text = "Cập Nhập";
            this.btnNumber.UseVisualStyleBackColor = true;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(6, 42);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(164, 22);
            this.txtNumber.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(361, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Các Ước Số";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(18, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 100);
            this.listBox1.TabIndex = 0;
            // 
            // btntotalwish
            // 
            this.btntotalwish.Location = new System.Drawing.Point(361, 222);
            this.btntotalwish.Name = "btntotalwish";
            this.btntotalwish.Size = new System.Drawing.Size(353, 45);
            this.btntotalwish.TabIndex = 2;
            this.btntotalwish.Text = "Tong cao uoc so";
            this.btntotalwish.UseVisualStyleBackColor = true;
            this.btntotalwish.Click += new System.EventHandler(this.btntotalwish_Click);
            // 
            // btnLuong
            // 
            this.btnLuong.Location = new System.Drawing.Point(361, 273);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Size = new System.Drawing.Size(353, 41);
            this.btnLuong.TabIndex = 3;
            this.btnLuong.Text = "Luong cac uoc so chan";
            this.btnLuong.UseVisualStyleBackColor = true;
            this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);
            // 
            // btnNguyenTo
            // 
            this.btnNguyenTo.Location = new System.Drawing.Point(361, 320);
            this.btnNguyenTo.Name = "btnNguyenTo";
            this.btnNguyenTo.Size = new System.Drawing.Size(353, 40);
            this.btnNguyenTo.TabIndex = 4;
            this.btnNguyenTo.Text = "Luong cac uoc so nguyen to";
            this.btnNguyenTo.UseVisualStyleBackColor = true;
            this.btnNguyenTo.Click += new System.EventHandler(this.btnNguyenTo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(349, 380);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNguyenTo);
            this.Controls.Add(this.btnLuong);
            this.Controls.Add(this.btntotalwish);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "bai7";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbNumber;
        private System.Windows.Forms.Button btnNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btntotalwish;
        private System.Windows.Forms.Button btnLuong;
        private System.Windows.Forms.Button btnNguyenTo;
        private System.Windows.Forms.Button btnExit;
    }
}

