﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtFont.Font = new Font("Times New Roman", txtFont.Font.Size, txtFont.Font.Style ^ FontStyle.Bold);
        }

        private void rbtn2_CheckedChanged(object sender, EventArgs e)
        {
            txtFont.Font = new Font("Arial", txtFont.Font.Size, txtFont.Font.Style ^ FontStyle.Bold);
        }

        private void rbtn3_CheckedChanged(object sender, EventArgs e)
        {
            txtFont.Font = new Font("Tahoma", txtFont.Font.Size, txtFont.Font.Style ^ FontStyle.Bold);
        }

        private void rbtn4_CheckedChanged(object sender, EventArgs e)
        {
            txtFont.Font = new Font("Courier New", txtFont.Font.Size, txtFont.Font.Style ^ FontStyle.Bold);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
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
