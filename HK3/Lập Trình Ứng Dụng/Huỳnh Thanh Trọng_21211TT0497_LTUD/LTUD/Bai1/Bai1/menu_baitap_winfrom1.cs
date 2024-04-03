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
    public partial class menu_baitap_winfrom1 : Form
    {
        public menu_baitap_winfrom1()
        {
            InitializeComponent();
        }

        private void bai1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.ShowDialog();
        }

        private void bai2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bai3 bai3 = new bai3();
            bai3.ShowDialog();
            
        }

        private void bai3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bai2.Bai2 bai2 = new bai2.Bai2();
            bai2.ShowDialog();
            
        }

        private void bai4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai4.bai4 bai4 = new Bai4.bai4();
            bai4.ShowDialog();
        }

        private void bai5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai5.Bai5 bai5 = new Bai5.Bai5();
            bai5.ShowDialog();
        }

        private void bai6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai6.bai6 bai6 = new Bai6.bai6();
            bai6.ShowDialog();
        }

        private void bai7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai7.bai7 bai7 = new Bai7.bai7();
            bai7.ShowDialog();
        }

        private void bai8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai8.Form1 bai8 = new Bai8.Form1();
            bai8.ShowDialog();
        }

        private void bai9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai9.bai9 bai9 = new Bai9.bai9();
            bai9.ShowDialog();
        }

        private void bai10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai10.Form1 bai10 = new Bai10.Form1();
            bai10.ShowDialog();
        }

        private void bai11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai11.Form1 bai11 = new Bai11.Form1();
            bai11.ShowDialog();
        }
        //form 2.................................................................




        private void bai1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 bai1 = new Form1();
            bai1.Show();
        }

        private void bai4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 bai4 = new Form5();
            bai4.Show();
        }

        private void bai8ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form8 bai8 = new Form8();
            bai8.Show();
        }

        private void bai9ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form9 bai9 = new Form9();
            bai9.Show();
        }

        private void bai6ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 bai6 = new Form6();
            bai6.Show();
        }

        private void bai10ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form10 bai10 = new Form10();
            bai10.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menu_baitap_winfrom1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("BAn co muon thoat!!!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bai7ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 bai7 = new Form7();
            bai7.Show();
        }

        private void bai2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 bai2 = new Form2();
            bai2.Show();
        }

        private void winfrom1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
