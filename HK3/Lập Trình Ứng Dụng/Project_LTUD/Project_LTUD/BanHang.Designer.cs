namespace Project_LTUD
{
    partial class BanHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbotenxe = new System.Windows.Forms.ComboBox();
            this.cbotenkh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txttt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmapx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvxe = new System.Windows.Forms.DataGridView();
            this.btnht = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnban = new System.Windows.Forms.Button();
            this.dtpkpn = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbotennv = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbokm = new System.Windows.Forms.ComboBox();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvxe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên xe";
            // 
            // cbotenxe
            // 
            this.cbotenxe.FormattingEnabled = true;
            this.cbotenxe.Location = new System.Drawing.Point(111, 21);
            this.cbotenxe.Name = "cbotenxe";
            this.cbotenxe.Size = new System.Drawing.Size(195, 24);
            this.cbotenxe.TabIndex = 1;
            this.cbotenxe.SelectedIndexChanged += new System.EventHandler(this.cbotenxe_SelectedIndexChanged);
            // 
            // cbotenkh
            // 
            this.cbotenkh.FormattingEnabled = true;
            this.cbotenkh.Location = new System.Drawing.Point(111, 74);
            this.cbotenkh.Name = "cbotenkh";
            this.cbotenkh.Size = new System.Drawing.Size(195, 24);
            this.cbotenkh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(453, 21);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(195, 22);
            this.txtsl.TabIndex = 5;
            this.txtsl.TextChanged += new System.EventHandler(this.txtsl_TextChanged);
            // 
            // txttt
            // 
            this.txttt.Location = new System.Drawing.Point(453, 77);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(195, 22);
            this.txttt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thành tiền";
            // 
            // txtmapx
            // 
            this.txtmapx.Location = new System.Drawing.Point(111, 134);
            this.txtmapx.Name = "txtmapx";
            this.txtmapx.Size = new System.Drawing.Size(195, 22);
            this.txtmapx.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã PX";
            // 
            // dgvxe
            // 
            this.dgvxe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvxe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvxe.Location = new System.Drawing.Point(0, 370);
            this.dgvxe.Name = "dgvxe";
            this.dgvxe.RowHeadersWidth = 51;
            this.dgvxe.RowTemplate.Height = 24;
            this.dgvxe.Size = new System.Drawing.Size(803, 150);
            this.dgvxe.TabIndex = 12;
            this.dgvxe.Click += new System.EventHandler(this.dgvxe_Click);
            // 
            // btnht
            // 
            this.btnht.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnht.Location = new System.Drawing.Point(552, 290);
            this.btnht.Name = "btnht";
            this.btnht.Size = new System.Drawing.Size(200, 41);
            this.btnht.TabIndex = 27;
            this.btnht.Text = "Hiển thị danh sách xe";
            this.btnht.UseVisualStyleBackColor = true;
            this.btnht.Click += new System.EventHandler(this.btnht_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 300);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Nhập mã xe cần tìm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(178, 297);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(140, 22);
            this.txttimkiem.TabIndex = 25;
            // 
            // btntimkiem
            // 
            this.btntimkiem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btntimkiem.Location = new System.Drawing.Point(354, 290);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(90, 41);
            this.btntimkiem.TabIndex = 24;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnban
            // 
            this.btnban.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnban.Location = new System.Drawing.Point(131, 230);
            this.btnban.Name = "btnban";
            this.btnban.Size = new System.Drawing.Size(90, 41);
            this.btnban.TabIndex = 28;
            this.btnban.Text = "Xác nhận";
            this.btnban.UseVisualStyleBackColor = true;
            this.btnban.Click += new System.EventHandler(this.btnban_Click);
            // 
            // dtpkpn
            // 
            this.dtpkpn.CustomFormat = "dd/MM/yyyy";
            this.dtpkpn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkpn.Location = new System.Drawing.Point(111, 183);
            this.dtpkpn.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkpn.Name = "dtpkpn";
            this.dtpkpn.Size = new System.Drawing.Size(195, 22);
            this.dtpkpn.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 80;
            this.label7.Text = "Ngày xuất";
            // 
            // cbotennv
            // 
            this.cbotennv.FormattingEnabled = true;
            this.cbotennv.Location = new System.Drawing.Point(453, 185);
            this.cbotennv.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbotennv.Name = "cbotennv";
            this.cbotennv.Size = new System.Drawing.Size(195, 24);
            this.cbotennv.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 188);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 82;
            this.label9.Text = "Tên nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 84;
            this.label6.Text = "Mã KM";
            // 
            // cbokm
            // 
            this.cbokm.FormattingEnabled = true;
            this.cbokm.Location = new System.Drawing.Point(453, 129);
            this.cbokm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbokm.Name = "cbokm";
            this.cbokm.Size = new System.Drawing.Size(195, 24);
            this.cbokm.TabIndex = 85;
            // 
            // btnthoat
            // 
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.Location = new System.Drawing.Point(502, 230);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(90, 41);
            this.btnthoat.TabIndex = 86;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 520);
            this.ControlBox = false;
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.cbokm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbotennv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpkpn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnban);
            this.Controls.Add(this.btnht);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.dgvxe);
            this.Controls.Add(this.txtmapx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbotenkh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbotenxe);
            this.Controls.Add(this.label1);
            this.Name = "BanHang";
            this.Text = "BanHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BanHang_FormClosing);
            this.Load += new System.EventHandler(this.BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvxe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbotenxe;
        private System.Windows.Forms.ComboBox cbotenkh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmapx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvxe;
        private System.Windows.Forms.Button btnht;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnban;
        private System.Windows.Forms.DateTimePicker dtpkpn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbotennv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbokm;
        private System.Windows.Forms.Button btnthoat;
    }
}