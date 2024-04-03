
namespace bai2
{
    partial class Bai2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnChia = new System.Windows.Forms.RadioButton();
            this.rbtnNhan = new System.Windows.Forms.RadioButton();
            this.rbtnTru = new System.Windows.Forms.RadioButton();
            this.rbtnCong = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "So 1 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "So 2 : ";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(205, 78);
            this.txtSo1.Multiline = true;
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(325, 22);
            this.txtSo1.TabIndex = 2;
            this.txtSo1.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(205, 137);
            this.txtSo2.Multiline = true;
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(325, 22);
            this.txtSo2.TabIndex = 3;
            this.txtSo2.TextChanged += new System.EventHandler(this.txtSo2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnChia);
            this.groupBox1.Controls.Add(this.rbtnNhan);
            this.groupBox1.Controls.Add(this.rbtnTru);
            this.groupBox1.Controls.Add(this.rbtnCong);
            this.groupBox1.Location = new System.Drawing.Point(126, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phep Tinh";
            // 
            // rbtnChia
            // 
            this.rbtnChia.AutoSize = true;
            this.rbtnChia.Location = new System.Drawing.Point(341, 57);
            this.rbtnChia.Name = "rbtnChia";
            this.rbtnChia.Size = new System.Drawing.Size(57, 21);
            this.rbtnChia.TabIndex = 3;
            this.rbtnChia.TabStop = true;
            this.rbtnChia.Text = "Chia";
            this.rbtnChia.UseVisualStyleBackColor = true;
            this.rbtnChia.CheckedChanged += new System.EventHandler(this.rbtnChia_CheckedChanged);
            // 
            // rbtnNhan
            // 
            this.rbtnNhan.AutoSize = true;
            this.rbtnNhan.Location = new System.Drawing.Point(234, 57);
            this.rbtnNhan.Name = "rbtnNhan";
            this.rbtnNhan.Size = new System.Drawing.Size(63, 21);
            this.rbtnNhan.TabIndex = 2;
            this.rbtnNhan.TabStop = true;
            this.rbtnNhan.Text = "Nhan";
            this.rbtnNhan.UseVisualStyleBackColor = true;
            this.rbtnNhan.CheckedChanged += new System.EventHandler(this.rbtnNhan_CheckedChanged);
            // 
            // rbtnTru
            // 
            this.rbtnTru.AutoSize = true;
            this.rbtnTru.Location = new System.Drawing.Point(123, 57);
            this.rbtnTru.Name = "rbtnTru";
            this.rbtnTru.Size = new System.Drawing.Size(51, 21);
            this.rbtnTru.TabIndex = 1;
            this.rbtnTru.TabStop = true;
            this.rbtnTru.Text = "Tru";
            this.rbtnTru.UseVisualStyleBackColor = true;
            this.rbtnTru.CheckedChanged += new System.EventHandler(this.rbtnTru_CheckedChanged);
            // 
            // rbtnCong
            // 
            this.rbtnCong.AutoSize = true;
            this.rbtnCong.Location = new System.Drawing.Point(6, 57);
            this.rbtnCong.Name = "rbtnCong";
            this.rbtnCong.Size = new System.Drawing.Size(62, 21);
            this.rbtnCong.TabIndex = 0;
            this.rbtnCong.TabStop = true;
            this.rbtnCong.Text = "Cong";
            this.rbtnCong.UseVisualStyleBackColor = true;
            this.rbtnCong.CheckedChanged += new System.EventHandler(this.rbtnCong_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ket qua";
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(205, 366);
            this.txtKetqua.Multiline = true;
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(325, 22);
            this.txtKetqua.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai2";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai2_FormClosing);
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnChia;
        private System.Windows.Forms.RadioButton rbtnNhan;
        private System.Windows.Forms.RadioButton rbtnTru;
        private System.Windows.Forms.RadioButton rbtnCong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

