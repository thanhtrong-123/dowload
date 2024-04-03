using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int R = 0;
        int G = 0;
        int B = 0;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 255;
            
            lbR.Text = "R = " + trackBar1.Value.ToString();
            R = trackBar1.Value;
            panelBackGroud.BackColor = Color.FromArgb(R,G,B);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            trackBar2.Minimum = 0;
            trackBar2.Maximum = 255;
            lbG.Text = "G = "+ trackBar2.Value.ToString();
            G = trackBar2.Value;
            panelBackGroud.BackColor = Color.FromArgb(R, G, B);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            trackBar3.Minimum = 0;
            trackBar3.Maximum = 255;
            lbB.Text = "B = " + trackBar3.Value.ToString();
            B = trackBar3.Value;
            panelBackGroud.BackColor = Color.FromArgb(R, G, B);

        }
    }
}
