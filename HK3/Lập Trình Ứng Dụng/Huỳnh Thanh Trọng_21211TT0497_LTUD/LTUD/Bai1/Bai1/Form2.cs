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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;

        }
      

        private void btnRun_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 100)
            {
                timer1.Enabled = false;
                MessageBox.Show("finish!!!");

            }
            else
            {

                this.progressBar1.Value += 1;
                label1.Text = "Processing " + progressBar1.Value;
            }
        }
    }
}
