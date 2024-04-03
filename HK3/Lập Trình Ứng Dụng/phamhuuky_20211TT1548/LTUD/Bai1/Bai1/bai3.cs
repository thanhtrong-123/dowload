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
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtNhapA.Text);
            float b = float.Parse(txtNhapB.Text);
            float c = -b / a;
            if (a == 0)
            {
                MessageBox.Show("Phuong trinh vo nghiem", "A = 0");
                if (b == 0)
                {
                    MessageBox.Show("Phuong trinh vo so nghiem", "B = 0");
                }
            }
            else
            {
                txtKQ.Text = c.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhapA.Clear();
            txtNhapB.Clear();
            txtKQ.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNhapA_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                this.errorProvider1.SetError(ctr, "Ban phai nhap so!!");
                txtNhapB.Enabled = false;
            }
            else
            {
                txtNhapB.Enabled = true;
                this.errorProvider1.Clear();
            }
        }

        private void txtNhapB_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                this.errorProvider1.SetError(ctr, "Ban phai nhap so !!!");
                btnGiai.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                btnGiai.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtKQ.Enabled = false;
            this.txtNhapB.Enabled = false;
            this.btnGiai.Enabled = false;
            this.btnXoa.Enabled = false;
        }

        private void txtNhapA_MouseLeave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                txtNhapA.BackColor = Color.Red;
            }
            else
            {
                txtNhapA.BackColor = SystemColors.Window;
            }
        }

        private void txtNhapB_MouseLeave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                txtNhapB.BackColor = Color.Red;
            }
            else
            {
                txtNhapB.BackColor = SystemColors.Window;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("BAn co muon thoat!!!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtNhapA_MouseEnter(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                txtNhapB.BackColor = SystemColors.Window;
            }
        }

        private void bai3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban co muon thoat", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (r == DialogResult.No)
            {
                e.Cancel = false;
            }
        }
    }
}
