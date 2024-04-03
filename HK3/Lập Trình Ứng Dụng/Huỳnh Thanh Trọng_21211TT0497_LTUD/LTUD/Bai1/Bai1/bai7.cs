using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class bai7 : Form
    {
        public bai7()
        {
            InitializeComponent();
        }

        private void btntotalwish_Click(object sender, EventArgs e)
        {
            uocso();
        }
        void uocso()
        {
            int uocso = int.Parse(cbNumber.Text);
            for (int i = 1; i < uocso; i++)
            {
                if (uocso % i == 0)
                {
                    MessageBox.Show($"Danh sach cac uoc so : {listBox1.Items.Add(i)}","Danh sach uoc so");
                }
            }
        }
        private void btnLuong_Click(object sender, EventArgs e)
        {
            int sum = 1;
            for (int i = 1; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Text.Length % i == 0)
                {
                    int x = (int)listBox1.Items[i];
                    sum += x;
                }
            }
            MessageBox.Show($"Tong cac uoc so la : {listBox1.Items.Add(sum).ToString()}", "Tong uoc so");
        }

        private void btnNguyenTo_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            cbNumber.Items.Add(txtNumber.Text);
            txtNumber.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban co muon thoat!!!","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
