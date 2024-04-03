namespace Project_LTUD
{
    partial class ThôngtinPN
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
            this.dgvpn = new System.Windows.Forms.DataGridView();
            this.btnht = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.cbomanv = new System.Windows.Forms.ComboBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtmapn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.dtpkpn = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpn
            // 
            this.dgvpn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvpn.Location = new System.Drawing.Point(0, 482);
            this.dgvpn.Margin = new System.Windows.Forms.Padding(4);
            this.dgvpn.Name = "dgvpn";
            this.dgvpn.RowHeadersWidth = 51;
            this.dgvpn.RowTemplate.Height = 24;
            this.dgvpn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpn.Size = new System.Drawing.Size(1219, 284);
            this.dgvpn.TabIndex = 60;
            this.dgvpn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpn_CellContentClick);
            this.dgvpn.Click += new System.EventHandler(this.dgvpn_Click);
            // 
            // btnht
            // 
            this.btnht.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnht.Location = new System.Drawing.Point(735, 357);
            this.btnht.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnht.Name = "btnht";
            this.btnht.Size = new System.Drawing.Size(312, 64);
            this.btnht.TabIndex = 59;
            this.btnht.Text = "Hiển thị danh sách phiếu nhập";
            this.btnht.UseVisualStyleBackColor = true;
            this.btnht.Click += new System.EventHandler(this.btnht_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 379);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 20);
            this.label8.TabIndex = 58;
            this.label8.Text = "Nhập mã phiếu nhập cần tìm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(261, 372);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(216, 27);
            this.txttimkiem.TabIndex = 57;
            // 
            // btntimkiem
            // 
            this.btntimkiem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btntimkiem.Location = new System.Drawing.Point(505, 353);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(140, 64);
            this.btntimkiem.TabIndex = 56;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // cbomanv
            // 
            this.cbomanv.FormattingEnabled = true;
            this.cbomanv.Location = new System.Drawing.Point(735, 46);
            this.cbomanv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbomanv.Name = "cbomanv";
            this.cbomanv.Size = new System.Drawing.Size(376, 28);
            this.cbomanv.TabIndex = 55;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(682, 269);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(140, 64);
            this.btnsua.TabIndex = 54;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(332, 266);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(140, 64);
            this.btnxoa.TabIndex = 53;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(8, 266);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(140, 64);
            this.btnthem.TabIndex = 52;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtmapn
            // 
            this.txtmapn.Location = new System.Drawing.Point(146, 42);
            this.txtmapn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmapn.Name = "txtmapn";
            this.txtmapn.Size = new System.Drawing.Size(376, 27);
            this.txtmapn.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(570, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Ngày nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(972, 266);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(140, 64);
            this.btnthoat.TabIndex = 61;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dtpkpn
            // 
            this.dtpkpn.CustomFormat = "dd/MM/yyyy";
            this.dtpkpn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkpn.Location = new System.Drawing.Point(142, 133);
            this.dtpkpn.Name = "dtpkpn";
            this.dtpkpn.Size = new System.Drawing.Size(380, 27);
            this.dtpkpn.TabIndex = 64;
            // 
            // ThôngtinPN
            // 
            this.AcceptButton = this.btnthem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 766);
            this.ControlBox = false;
            this.Controls.Add(this.dtpkpn);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dgvpn);
            this.Controls.Add(this.btnht);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.cbomanv);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtmapn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThôngtinPN";
            this.Text = "ThôngtinPN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThôngtinPN_FormClosing);
            this.Load += new System.EventHandler(this.ThôngtinPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpn;
        private System.Windows.Forms.Button btnht;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.ComboBox cbomanv;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtmapn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DateTimePicker dtpkpn;
    }
}