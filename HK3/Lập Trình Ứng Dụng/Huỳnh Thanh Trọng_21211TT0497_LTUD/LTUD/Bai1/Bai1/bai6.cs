using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class bai6 : Form
    {
        public bai6()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            pictrure.Image = Image.FromFile(@"D:\LTUD\Bai1/vn.png");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictrure.Image = Image.FromFile(@"D:\LTUD\Bai1/usa.png");

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictrure.Image = Image.FromFile(@"D:\LTUD\Bai1/philip.png");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictrure.Image = Image.FromFile(@"D:\LTUD\Bai1/italy.png");
        }
    }
}
