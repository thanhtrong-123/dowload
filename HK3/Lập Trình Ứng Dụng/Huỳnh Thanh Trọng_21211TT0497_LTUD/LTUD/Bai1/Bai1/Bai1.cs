using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int tuoi = DateTime.Now.Year - Convert.ToInt32(txtYob.Text);
            string s = "Ten cua Ban la : " + txtYourName.Text + "\nTuoi cua ban la: " +tuoi.ToString();
            MessageBox.Show(s);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban co muon thoat!!!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYob.Clear();
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtYourName_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsLetter(ctr.Text,ctr.Text.Length - 1))
            {
                this.errorProvider1.SetError(ctr, "Ban phai nhap chu");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtYob_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text,ctr.Text.Length - 1))
            {
                this.errorProvider1.SetError(ctr, "Ban phai nhap so");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
    }
}
