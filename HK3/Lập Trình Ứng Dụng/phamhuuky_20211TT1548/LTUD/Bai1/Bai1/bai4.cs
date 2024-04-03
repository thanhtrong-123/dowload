using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
            
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {

            lblaptrinh.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblaptrinh.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblaptrinh.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblaptrinh.ForeColor = Color.Black;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblaptrinh.Font = new Font(lblaptrinh.Font.Name, lblaptrinh.Font.Size, lblaptrinh.Font.Style ^ FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblaptrinh.Font = new Font(lblaptrinh.Font.Name, lblaptrinh.Font.Size, lblaptrinh.Font.Style ^ FontStyle.Italic);
        }

        private void chkUnderlined_CheckedChanged(object sender, EventArgs e)
        {
            lblaptrinh.Font = new Font(lblaptrinh.Font.Name, lblaptrinh.Font.Size, lblaptrinh.Font.Style ^ FontStyle.Underline);
        }


        private void txtNhapten_TextChanged(object sender, EventArgs e)
        {
            lblaptrinh.Text = txtNhapten.Text;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban muon thoat !!!", "Exit",MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
