
namespace Bai8
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb = new System.Windows.Forms.ListBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSoLe = new System.Windows.Forms.Button();
            this.btnSoChan = new System.Windows.Forms.Button();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnTangLen2 = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(318, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTBOX";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb);
            this.groupBox2.Controls.Add(this.btnNhap);
            this.groupBox2.Controls.Add(this.txtNhap);
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 315);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listbox";
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 16;
            this.lb.Location = new System.Drawing.Point(6, 116);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(360, 180);
            this.lb.TabIndex = 1;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(6, 63);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(360, 47);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(6, 35);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(360, 22);
            this.txtNhap.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSoLe);
            this.groupBox3.Controls.Add(this.btnSoChan);
            this.groupBox3.Controls.Add(this.btnBinhPhuong);
            this.groupBox3.Controls.Add(this.btnTangLen2);
            this.groupBox3.Controls.Add(this.btnXoaChon);
            this.groupBox3.Controls.Add(this.btnXoaDauCuoi);
            this.groupBox3.Controls.Add(this.btnTong);
            this.groupBox3.Location = new System.Drawing.Point(424, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 315);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xử lý  Listbox";
            // 
            // btnSoLe
            // 
            this.btnSoLe.Location = new System.Drawing.Point(6, 268);
            this.btnSoLe.Name = "btnSoLe";
            this.btnSoLe.Size = new System.Drawing.Size(352, 41);
            this.btnSoLe.TabIndex = 6;
            this.btnSoLe.Text = "Chon So Le";
            this.btnSoLe.UseVisualStyleBackColor = true;
            this.btnSoLe.Click += new System.EventHandler(this.btnSoLe_Click);
            // 
            // btnSoChan
            // 
            this.btnSoChan.Location = new System.Drawing.Point(6, 223);
            this.btnSoChan.Name = "btnSoChan";
            this.btnSoChan.Size = new System.Drawing.Size(352, 39);
            this.btnSoChan.TabIndex = 5;
            this.btnSoChan.Text = "Chon So Chan";
            this.btnSoChan.UseVisualStyleBackColor = true;
            this.btnSoChan.Click += new System.EventHandler(this.btnSoChan_Click);
            // 
            // btnBinhPhuong
            // 
            this.btnBinhPhuong.Location = new System.Drawing.Point(6, 180);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new System.Drawing.Size(352, 37);
            this.btnBinhPhuong.TabIndex = 4;
            this.btnBinhPhuong.Text = "Thay Bang Binh Phuong";
            this.btnBinhPhuong.UseVisualStyleBackColor = true;
            this.btnBinhPhuong.Click += new System.EventHandler(this.btnBinhPhuong_Click);
            // 
            // btnTangLen2
            // 
            this.btnTangLen2.Location = new System.Drawing.Point(6, 141);
            this.btnTangLen2.Name = "btnTangLen2";
            this.btnTangLen2.Size = new System.Drawing.Size(352, 33);
            this.btnTangLen2.TabIndex = 3;
            this.btnTangLen2.Text = "Tang Moi Phan Tu Len 2";
            this.btnTangLen2.UseVisualStyleBackColor = true;
            this.btnTangLen2.Click += new System.EventHandler(this.btnTangLen2_Click);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Location = new System.Drawing.Point(6, 102);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(352, 33);
            this.btnXoaChon.TabIndex = 2;
            this.btnXoaChon.Text = "Xoa Phan Tu Dang Chon";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // btnXoaDauCuoi
            // 
            this.btnXoaDauCuoi.Location = new System.Drawing.Point(6, 63);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new System.Drawing.Size(352, 36);
            this.btnXoaDauCuoi.TabIndex = 1;
            this.btnXoaDauCuoi.Text = "Xoa Phan Tu Dau Va Cuoi";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaDauCuoi.Click += new System.EventHandler(this.btnXoaDauCuoi_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(6, 21);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(352, 36);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tong Cac Phan Tu Trong List";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(12, 437);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(776, 40);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "Kết Thúc";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnSoLe;
        private System.Windows.Forms.Button btnSoChan;
        private System.Windows.Forms.Button btnBinhPhuong;
        private System.Windows.Forms.Button btnTangLen2;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnXoaDauCuoi;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.ListBox lb;
    }
}

