
namespace Bai11
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbB = new System.Windows.Forms.Label();
            this.lbG = new System.Windows.Forms.Label();
            this.lbR = new System.Windows.Forms.Label();
            this.panelBackGroud = new System.Windows.Forms.Panel();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(21, 38);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(246, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbB);
            this.groupBox1.Controls.Add(this.lbG);
            this.groupBox1.Controls.Add(this.lbR);
            this.groupBox1.Controls.Add(this.panelBackGroud);
            this.groupBox1.Controls.Add(this.trackBar3);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(126, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.ForeColor = System.Drawing.Color.Blue;
            this.lbB.Location = new System.Drawing.Point(308, 162);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(41, 17);
            this.lbB.TabIndex = 6;
            this.lbB.Text = "B = 0";
            // 
            // lbG
            // 
            this.lbG.AutoSize = true;
            this.lbG.ForeColor = System.Drawing.Color.Green;
            this.lbG.Location = new System.Drawing.Point(308, 111);
            this.lbG.Name = "lbG";
            this.lbG.Size = new System.Drawing.Size(43, 17);
            this.lbG.TabIndex = 5;
            this.lbG.Text = "G = 0";
            // 
            // lbR
            // 
            this.lbR.AutoSize = true;
            this.lbR.BackColor = System.Drawing.SystemColors.Control;
            this.lbR.ForeColor = System.Drawing.Color.Red;
            this.lbR.Location = new System.Drawing.Point(308, 58);
            this.lbR.Name = "lbR";
            this.lbR.Size = new System.Drawing.Size(42, 17);
            this.lbR.TabIndex = 4;
            this.lbR.Text = "R = 0";
            // 
            // panelBackGroud
            // 
            this.panelBackGroud.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelBackGroud.Location = new System.Drawing.Point(406, 11);
            this.panelBackGroud.Name = "panelBackGroud";
            this.panelBackGroud.Size = new System.Drawing.Size(164, 228);
            this.panelBackGroud.TabIndex = 3;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(21, 162);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(246, 56);
            this.trackBar3.TabIndex = 2;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(21, 100);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(246, 56);
            this.trackBar2.TabIndex = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbG;
        private System.Windows.Forms.Label lbR;
        private System.Windows.Forms.Panel panelBackGroud;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
    }
}

