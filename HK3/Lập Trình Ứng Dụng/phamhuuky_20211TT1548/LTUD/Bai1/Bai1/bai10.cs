using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void rbtnI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnII_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnIII_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnIV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text;
            string fullName = txtName.Text;
            string S_year = cbSyear.Text;
            string c_lass = cbClass.Text;
            string rbtncheck;
            if (rbtnI.Checked == true)
            {
                rbtncheck = rbtnI.Text;
            }
            else if (rbtnII.Checked == true)
            {
                rbtncheck = rbtnII.Text;
            }
            else if (rbtnIII.Checked == true)
            {
                rbtncheck = rbtnIII.Text;
            }
            else
            {
                rbtncheck = rbtnIV.Text;
            }
            string str = "";
            foreach (string item in ckListBoxS.CheckedItems)
            {
                str += item;
            }
            MessageBox.Show($" MSVV la : {mssv}\n Ho ten day du la : {fullName}\n Niem Khoa : {S_year}\n Lop hoc : {c_lass}\n Hoc ky : {rbtncheck}\n Mon hoc : {str}", "Imformation");
        }
        private void btnAbort_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ckListBoxS_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void txtName_Enter(object sender, EventArgs e)
        {

        }

        private void txtMSSV_Enter(object sender, EventArgs e)
        {

        }

        private void txtSYear_Enter(object sender, EventArgs e)
        {

        }

        private void txtClass_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban co muon thoat!!!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
