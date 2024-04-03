namespace Project_LTUD
{
    partial class Thôngtinnv
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
            this.btnht = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.dgvnv = new System.Windows.Forms.DataGridView();
            this.cboml = new System.Windows.Forms.ComboBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpknv = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radnam = new System.Windows.Forms.RadioButton();
            this.radnu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnht
            // 
            this.btnht.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnht.Location = new System.Drawing.Point(705, 356);
            this.btnht.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnht.Name = "btnht";
            this.btnht.Size = new System.Drawing.Size(250, 51);
            this.btnht.TabIndex = 46;
            this.btnht.Text = "Hiển thị danh sách nv";
            this.btnht.UseVisualStyleBackColor = true;
            this.btnht.Click += new System.EventHandler(this.btnht_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 369);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Nhập mã nv cần tìm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(237, 365);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(174, 27);
            this.txttimkiem.TabIndex = 44;
            // 
            // btntimkiem
            // 
            this.btntimkiem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btntimkiem.Location = new System.Drawing.Point(457, 356);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(112, 51);
            this.btntimkiem.TabIndex = 43;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // dgvnv
            // 
            this.dgvnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvnv.Location = new System.Drawing.Point(0, 453);
            this.dgvnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvnv.Name = "dgvnv";
            this.dgvnv.RowHeadersWidth = 51;
            this.dgvnv.RowTemplate.Height = 24;
            this.dgvnv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvnv.Size = new System.Drawing.Size(1055, 248);
            this.dgvnv.TabIndex = 42;
            this.dgvnv.Click += new System.EventHandler(this.dgvnv_Click);
            // 
            // cboml
            // 
            this.cboml.FormattingEnabled = true;
            this.cboml.Location = new System.Drawing.Point(705, 152);
            this.cboml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboml.Name = "cboml";
            this.cboml.Size = new System.Drawing.Size(302, 28);
            this.cboml.TabIndex = 41;
            // 
            // btnthoat
            // 
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.Location = new System.Drawing.Point(875, 247);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(112, 51);
            this.btnthoat.TabIndex = 40;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(619, 249);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(112, 51);
            this.btnsua.TabIndex = 39;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(339, 247);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(112, 51);
            this.btnxoa.TabIndex = 38;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(79, 247);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(112, 51);
            this.btnthem.TabIndex = 37;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(705, 88);
            this.txtluong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(302, 27);
            this.txtluong.TabIndex = 35;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(124, 82);
            this.txttennv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(302, 27);
            this.txttennv.TabIndex = 32;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(109, 21);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(302, 27);
            this.txtmanv.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tên loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(574, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Lương";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã NV";
            // 
            // dtpknv
            // 
            this.dtpknv.CustomFormat = "dd/MM/yyyy";
            this.dtpknv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpknv.Location = new System.Drawing.Point(705, 19);
            this.dtpknv.Name = "dtpknv";
            this.dtpknv.Size = new System.Drawing.Size(302, 27);
            this.dtpknv.TabIndex = 65;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radnu);
            this.groupBox1.Controls.Add(this.radnam);
            this.groupBox1.Location = new System.Drawing.Point(27, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 77);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phái";
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Location = new System.Drawing.Point(123, 36);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(65, 24);
            this.radnam.TabIndex = 0;
            this.radnam.TabStop = true;
            this.radnam.Text = "Nam";
            this.radnam.UseVisualStyleBackColor = true;
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.Location = new System.Drawing.Point(234, 36);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(51, 24);
            this.radnu.TabIndex = 1;
            this.radnu.TabStop = true;
            this.radnu.Text = "Nữ";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // Thôngtinnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 701);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpknv);
            this.Controls.Add(this.btnht);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.dgvnv);
            this.Controls.Add(this.cboml);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtluong);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Thôngtinnv";
            this.Text = "Thôngtinnv";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Thôngtinnv_FormClosing);
            this.Load += new System.EventHandler(this.Thôngtinnv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnht;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridView dgvnv;
        private System.Windows.Forms.ComboBox cboml;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpknv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radnu;
        private System.Windows.Forms.RadioButton radnam;
    }
}