using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1)) 
            {
                this.errorProvider1.SetError(ctr, "Ban nhap phai la so !!!");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtSo2_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                this.errorProvider1.SetError(ctr, "Ban nhap phai la so !!!");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void rbtnCong_CheckedChanged(object sender, EventArgs e)
        {
            int so1 = Convert.ToInt32(txtSo1.Text);
            int so2 = Convert.ToInt32(txtSo2.Text);
            txtKetqua.Text = (so1 + so2).ToString();
        }

        private void rbtnTru_CheckedChanged(object sender, EventArgs e)
        {
            int so1 = Convert.ToInt32(txtSo1.Text);
            int so2 = Convert.ToInt32(txtSo2.Text);
            txtKetqua.Text = (so1 - so2).ToString();
        }

        private void rbtnNhan_CheckedChanged(object sender, EventArgs e)
        {
            int so1 = Convert.ToInt32(txtSo1.Text);
            int so2 = Convert.ToInt32(txtSo2.Text);
            txtKetqua.Text = (so1 * so2).ToString();
        }

        private void rbtnChia_CheckedChanged(object sender, EventArgs e)
        {
            int so1 = Convert.ToInt32(txtSo1.Text);
            int so2 = Convert.ToInt32(txtSo2.Text);
            txtKetqua.Text = (so1 / so2).ToString();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

        private void Bai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban co muon thoat", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (r == DialogResult.No)
            {
                e.Cancel = false;
            }
        }
    }
}
