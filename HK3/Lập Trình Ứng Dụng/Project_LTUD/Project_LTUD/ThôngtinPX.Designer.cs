namespace Project_LTUD
{
    partial class ThôngtinPX
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
            this.dtpkpn = new System.Windows.Forms.DateTimePicker();
            this.btnthoat = new System.Windows.Forms.Button();
            this.dgvpx = new System.Windows.Forms.DataGridView();
            this.btnht = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.cbotennv = new System.Windows.Forms.ComboBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtmapx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbotenkh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpx)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpkpn
            // 
            this.dtpkpn.CustomFormat = "dd/MM/yyyy";
            this.dtpkpn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkpn.Location = new System.Drawing.Point(188, 146);
            this.dtpkpn.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkpn.Name = "dtpkpn";
            this.dtpkpn.Size = new System.Drawing.Size(395, 27);
            this.dtpkpn.TabIndex = 79;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(1020, 306);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(175, 80);
            this.btnthoat.TabIndex = 78;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dgvpx
            // 
            this.dgvpx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvpx.Location = new System.Drawing.Point(0, 506);
            this.dgvpx.Margin = new System.Windows.Forms.Padding(5);
            this.dgvpx.Name = "dgvpx";
            this.dgvpx.RowHeadersWidth = 51;
            this.dgvpx.RowTemplate.Height = 24;
            this.dgvpx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpx.Size = new System.Drawing.Size(1310, 225);
            this.dgvpx.TabIndex = 77;
            this.dgvpx.Click += new System.EventHandler(this.dgvpx_Click);
            // 
            // btnht
            // 
            this.btnht.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnht.Location = new System.Drawing.Point(752, 415);
            this.btnht.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnht.Name = "btnht";
            this.btnht.Size = new System.Drawing.Size(390, 80);
            this.btnht.TabIndex = 76;
            this.btnht.Text = "Hiển thị danh sách phiếu xuất";
            this.btnht.UseVisualStyleBackColor = true;
            this.btnht.Click += new System.EventHandler(this.btnht_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 451);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 20);
            this.label8.TabIndex = 75;
            this.label8.Text = "Nhập mã phiếu xuất cần tìm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(247, 448);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(269, 27);
            this.txttimkiem.TabIndex = 74;
            // 
            // btntimkiem
            // 
            this.btntimkiem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btntimkiem.Location = new System.Drawing.Point(552, 415);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(175, 80);
            this.btntimkiem.TabIndex = 73;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // cbotennv
            // 
            this.cbotennv.FormattingEnabled = true;
            this.cbotennv.Location = new System.Drawing.Point(850, 39);
            this.cbotennv.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbotennv.Name = "cbotennv";
            this.cbotennv.Size = new System.Drawing.Size(376, 28);
            this.cbotennv.TabIndex = 72;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(658, 310);
            this.btnsua.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(175, 80);
            this.btnsua.TabIndex = 71;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(341, 306);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(175, 80);
            this.btnxoa.TabIndex = 70;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(38, 310);
            this.btnthem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(175, 80);
            this.btnthem.TabIndex = 69;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtmapx
            // 
            this.txtmapx.Location = new System.Drawing.Point(194, 32);
            this.txtmapx.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtmapx.Name = "txtmapx";
            this.txtmapx.Size = new System.Drawing.Size(390, 27);
            this.txtmapx.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(724, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 67;
            this.label7.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Ngày xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Mã phiếu xuất";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbotenkh
            // 
            this.cbotenkh.FormattingEnabled = true;
            this.cbotenkh.Location = new System.Drawing.Point(850, 148);
            this.cbotenkh.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbotenkh.Name = "cbotenkh";
            this.cbotenkh.Size = new System.Drawing.Size(376, 28);
            this.cbotenkh.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(710, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "Tên khách hàng";
            // 
            // ThôngtinPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 731);
            this.ControlBox = false;
            this.Controls.Add(this.cbotenkh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpkpn);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dgvpx);
            this.Controls.Add(this.btnht);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.cbotennv);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtmapx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThôngtinPX";
            this.Text = "ThôngtinPX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThôngtinPX_FormClosing);
            this.Load += new System.EventHandler(this.ThôngtinPX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpkpn;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView dgvpx;
        private System.Windows.Forms.Button btnht;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.ComboBox cbotennv;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtmapx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbotenkh;
        private System.Windows.Forms.Label label3;
    }
}