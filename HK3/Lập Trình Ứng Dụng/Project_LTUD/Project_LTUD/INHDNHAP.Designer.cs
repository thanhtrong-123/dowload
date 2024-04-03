
namespace Project_LTUD
{
    partial class INHDNHAP
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnxem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.rpthdnhap1 = new Project_LTUD.rpthdnhap();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 138);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rpthdnhap1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(932, 350);
            this.crystalReportViewer1.TabIndex = 7;
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(405, 18);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(104, 34);
            this.btnxem.TabIndex = 6;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập mã nhà cung cấp:";
            // 
            // txtmancc
            // 
            this.txtmancc.Location = new System.Drawing.Point(222, 24);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(148, 22);
            this.txtmancc.TabIndex = 4;
            // 
            // INHDNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 488);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmancc);
            this.Name = "INHDNHAP";
            this.Text = "INHDNHAP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmancc;
        private rpthdnhap rpthdnhap1;
    }
}