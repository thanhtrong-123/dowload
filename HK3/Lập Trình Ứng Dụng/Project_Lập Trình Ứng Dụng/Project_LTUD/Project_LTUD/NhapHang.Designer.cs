namespace Project_LTUD
{
    partial class NhapHang
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
            this.cbotennv = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpkpn = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnnhap = new System.Windows.Forms.Button();
            this.btnht = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.dgvxe = new System.Windows.Forms.DataGridView();
            this.txtmapn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbotencc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbotenxe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvxe)).BeginInit();
            this.SuspendLayout();
            // 
            // cbotennv
            // 
            this.cbotennv.FormattingEnabled = true;
            this.cbotennv.Location = new System.Drawing.Point(453, 175);
            this.cbotennv.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbotennv.Name = "cbotennv";
            this.cbotennv.Size = new System.Drawing.Size(195, 24);
            this.cbotennv.TabIndex = 103;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 178);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 102;
            this.label9.Text = "Tên nhân viên";
            // 
            // dtpkpn
            // 
            this.dtpkpn.CustomFormat = "dd/MM/yyyy";
            this.dtpkpn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkpn.Location = new System.Drawing.Point(111, 173);
            this.dtpkpn.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkpn.Name = "dtpkpn";
            this.dtpkpn.Size = new System.Drawing.Size(195, 22);
            this.dtpkpn.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 100;
            this.label7.Text = "Ngày nhập";
            // 
            // btnnhap
            // 
            this.btnnhap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnnhap.Location = new System.Drawing.Point(126, 223);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(90, 41);
            this.btnnhap.TabIndex = 99;
            this.btnnhap.Text = "Xác nhận";
            this.btnnhap.UseVisualStyleBackColor = true;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // btnht
            // 
            this.btnht.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnht.Location = new System.Drawing.Point(552, 280);
            this.btnht.Name = "btnht";
            this.btnht.Size = new System.Drawing.Size(200, 41);
            this.btnht.TabIndex = 98;
            this.btnht.Text = "Hiển thị danh sách xe";
            this.btnht.UseVisualStyleBackColor = true;
            this.btnht.Click += new System.EventHandler(this.btnht_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 290);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 97;
            this.label8.Text = "Nhập mã xe cần tìm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(178, 287);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(140, 22);
            this.txttimkiem.TabIndex = 96;
            // 
            // btntimkiem
            // 
            this.btntimkiem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btntimkiem.Location = new System.Drawing.Point(354, 280);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(90, 41);
            this.btntimkiem.TabIndex = 95;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // dgvxe
            // 
            this.dgvxe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvxe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvxe.Location = new System.Drawing.Point(0, 339);
            this.dgvxe.Name = "dgvxe";
            this.dgvxe.RowHeadersWidth = 51;
            this.dgvxe.RowTemplate.Height = 24;
            this.dgvxe.Size = new System.Drawing.Size(802, 150);
            this.dgvxe.TabIndex = 94;
            this.dgvxe.Click += new System.EventHandler(this.dgvxe_Click);
            // 
            // txtmapn
            // 
            this.txtmapn.Location = new System.Drawing.Point(111, 124);
            this.txtmapn.Name = "txtmapn";
            this.txtmapn.Size = new System.Drawing.Size(195, 22);
            this.txtmapn.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 92;
            this.label5.Text = "Mã PN";
            // 
            // txttt
            // 
            this.txttt.Location = new System.Drawing.Point(453, 67);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(195, 22);
            this.txttt.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 90;
            this.label4.Text = "Thành tiền";
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(453, 11);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(195, 22);
            this.txtsl.TabIndex = 89;
            this.txtsl.TextChanged += new System.EventHandler(this.txtsl_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 88;
            this.label3.Text = "Số lượng";
            // 
            // cbotencc
            // 
            this.cbotencc.FormattingEnabled = true;
            this.cbotencc.Location = new System.Drawing.Point(111, 64);
            this.cbotencc.Name = "cbotencc";
            this.cbotencc.Size = new System.Drawing.Size(195, 24);
            this.cbotencc.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 86;
            this.label2.Text = "Tên nhà CC";
            // 
            // cbotenxe
            // 
            this.cbotenxe.FormattingEnabled = true;
            this.cbotenxe.Location = new System.Drawing.Point(111, 11);
            this.cbotenxe.Name = "cbotenxe";
            this.cbotenxe.Size = new System.Drawing.Size(195, 24);
            this.cbotenxe.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 84;
            this.label1.Text = "Tên xe";
            // 
            // btnthoat
            // 
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.Location = new System.Drawing.Point(558, 223);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(90, 41);
            this.btnthoat.TabIndex = 104;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 41);
            this.button1.TabIndex = 105;
            this.button1.Text = "In hóa đơn nhập hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 489);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.cbotennv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpkpn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnnhap);
            this.Controls.Add(this.btnht);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.dgvxe);
            this.Controls.Add(this.txtmapn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbotencc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbotenxe);
            this.Controls.Add(this.label1);
            this.Name = "NhapHang";
            this.Text = "NhapHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhapHang_FormClosing);
            this.Load += new System.EventHandler(this.NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvxe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbotennv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpkpn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.Button btnht;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridView dgvxe;
        private System.Windows.Forms.TextBox txtmapn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbotencc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbotenxe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button button1;
    }
}