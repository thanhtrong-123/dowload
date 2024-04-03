using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ôn_LTUD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = null;
            if (form1 == null || form1.IsDisposed)
            {
                form1 = new Form1();
                form1.Show();

            }
            else
            {
                form1.BringToFront();
            }
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = null;
            form2 = new Form2();
            form2.Show();
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban muon thoat khong", "có", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = null;
            form3 = new Form3();
            form3.Show();
        }
    }
}
