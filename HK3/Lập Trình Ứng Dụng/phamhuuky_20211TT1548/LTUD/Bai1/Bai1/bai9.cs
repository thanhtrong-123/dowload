using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class bai9 : Form
    {
        public bai9()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string z = txtNhap.Text;
            if (z.Length > 0 )
            {
                listBox1.Items.Add(z);
                txtNhap.Clear();
            }
            else
            {
                MessageBox.Show("Vui long khong duoc de trong!!!", "Pls");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string z = txtNhap.Text;
                if (z.Length > 0)
                {
                    listBox1.Items.Add(z);
                    txtNhap.Clear();
                }
                else
                {
                    MessageBox.Show("Vui long khong duoc de trong!!!", "Pls");
                }
            }
        }

        private void btnToB_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                
            }
        }

        private void btnToA_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void btnAllB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Remove(listBox1.Items[i]);
            }
        }

        private void btnAllA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox1.Items.Add(listBox2.Items[i]);
            }
            for (int i = listBox2.Items.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Remove(listBox2.Items[i]);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you leave application !!!","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                
                if (e.KeyCode == Keys.Shift && (e.Alt))
                {
                    listBox1.SetSelected(i, true);
                }
                
                listBox1.SelectionMode = SelectionMode.MultiExtended;
                
            }
        }
    }
}
