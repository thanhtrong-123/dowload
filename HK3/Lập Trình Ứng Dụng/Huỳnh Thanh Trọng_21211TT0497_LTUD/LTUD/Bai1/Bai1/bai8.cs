using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnNhap_Click(object sender, EventArgs e)
        {
            int c = txtNhap.Text.Length;
            if (c > 0)
            {
                
                int a = int.Parse(txtNhap.Text);
                lb.Items.Add(a);
            }
            else
            {
                MessageBox.Show("Vui long nhap lai", "Agian");
            }
            txtNhap.Clear();
        }



        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            lb.Items.Remove(lb.Items[0]);
            lb.Items.RemoveAt(lb.Items.Count - 1);
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            lb.Items.Remove(lb.SelectedItem);
        }

        private void btnTangLen2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb.Items.Count; i++)
            {
                int x = (int)lb.Items[i];
                lb.Items[i] = x + 2;
            }   
        }
        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb.Items.Count; i++)
            {
                int y = (int)lb.Items[i];
                y = y ^ y;
                lb.Items[i] = y;
            }
        }

        private void btnSoChan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb.Items.Count; i++)
            {
                int x = (int)lb.Items[i];
                if (x % 2 == 0)
                  lb.SelectedIndex = i;
                lb.SetSelected(i, true);
            }
        }

        private void btnSoLe_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < lb.Items.Count; i++)
            {
                int x = (int)lb.Items[i];
                if (x % 2 != 0)
                    lb.SelectedIndex = i;
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < lb.Items.Count; i++)
            {
                int x = (int)lb.Items[i];
                sum += x;
            }
            lb.Items.Add("Tong la = " + sum);
            MessageBox.Show($"Tong = {sum}","Tong tat ca cac so");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban co muon thoat !!!","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
