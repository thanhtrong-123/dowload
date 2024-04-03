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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            string name_employee = txtName.Text;
            string birt = mxtDob.Text;
            string address = txtAddress.Text;
            string city = txtcity.Text;
            string country = cbCountry.Text;
            string Qualification = txtQualifycation.Text;
            string phone = mtPhone.Text;
            string email = txtEmail.Text;
            string joinning = dtPicker.Text;
           
            MessageBox.Show($"Name employee : {name_employee}\nBirt of day : {birt}\nAddress : {address}\nCity : {city}" +
                $"\nCountry : {country}\nQuatification : {Qualification}\nPhone : {phone}\nEmail : {email}\nDate of Joinning : {joinning}", "information's employee");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban co muon thoat!!!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0)
            {
                this.errorProvider1.Clear();
                txtName.TabStop = true;
                mxtDob.TabStop = true;
                txtAddress.TabStop = true;
                txtcity.TabStop = true;
                cbCountry.TabStop = true;
                txtQualifycation.TabStop = true;
                mtPhone.TabStop = true;
                txtEmail.TabStop = true;
                dtPicker.TabStop = true;
                btnSubmit.TabStop = true;
                btnExit.TabStop = true;
            }
            else
            {
                this.errorProvider1.SetError(ctr, "Khong duoc bo trong");
                txtName.TabStop = true;
                mxtDob.TabStop = false;
                txtAddress.TabStop = false;
                txtcity.TabStop = false;
                cbCountry.TabStop = false;
                txtQualifycation.TabStop = false;
                mtPhone.TabStop = false;
                txtEmail.TabStop = false;
                dtPicker.TabStop = false;
                btnSubmit.TabStop = false;
                btnExit.TabStop = false;
            }
        }

        private void mxtDob_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0)
            {
                this.errorProvider1.Clear();
                txtName.TabStop = true;
                mxtDob.TabStop = true;
                txtAddress.TabStop = true;
                txtcity.TabStop = true;
                cbCountry.TabStop = true;
                txtQualifycation.TabStop = true;
                mtPhone.TabStop = true;
                txtEmail.TabStop = true;
                dtPicker.TabStop = true;
                btnSubmit.TabStop = true;
                btnExit.TabStop = true;
            }
            else
            {
                this.errorProvider1.SetError(ctr, "Khong duoc bo trong");
                txtName.TabStop = false;
                mxtDob.TabStop = true;
                txtAddress.TabStop = false;
                txtcity.TabStop = false;
                cbCountry.TabStop = false;
                txtQualifycation.TabStop = false;
                mtPhone.TabStop = false;
                txtEmail.TabStop = false;
                dtPicker.TabStop = false;
                btnSubmit.TabStop = false;
                btnExit.TabStop = false;
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0)
            {
                this.errorProvider1.Clear();
                txtName.TabStop = true;
                mxtDob.TabStop = true;
                txtAddress.TabStop = true;
                txtcity.TabStop = true;
                cbCountry.TabStop = true;
                txtQualifycation.TabStop = true;
                mtPhone.TabStop = true;
                txtEmail.TabStop = true;
                dtPicker.TabStop = true;
                btnSubmit.TabStop = true;
                btnExit.TabStop = true;
            }
            else
            {
                this.errorProvider1.SetError(ctr, "Khong duoc bo trong");
                txtName.TabStop = true;
                mxtDob.TabStop = false;
                txtAddress.TabStop = true;
                txtcity.TabStop = false;
                cbCountry.TabStop = false;
                txtQualifycation.TabStop = false;
                mtPhone.TabStop = false;
                txtEmail.TabStop = false;
                dtPicker.TabStop = false;
                btnSubmit.TabStop = false;
                btnExit.TabStop = false;
            }
        }

        private void txtcity_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0)
            {
                this.errorProvider1.Clear();
                txtName.TabStop = true;
                mxtDob.TabStop = true;
                txtAddress.TabStop = true;
                txtcity.TabStop = true;
                cbCountry.TabStop = true;
                txtQualifycation.TabStop = true;
                mtPhone.TabStop = true;
                txtEmail.TabStop = true;
                dtPicker.TabStop = true;
                btnSubmit.TabStop = true;
                btnExit.TabStop = true;
            }
            else
            {
                this.errorProvider1.SetError(ctr, "Khong duoc bo trong");
                txtName.TabStop = true;
                mxtDob.TabStop = false;
                txtAddress.TabStop = false;
                txtcity.TabStop = true;
                cbCountry.TabStop = false;
                txtQualifycation.TabStop = false;
                mtPhone.TabStop = false;
                txtEmail.TabStop = false;
                dtPicker.TabStop = false;
                btnSubmit.TabStop = false;
                btnExit.TabStop = false;
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0)
            {
                this.errorProvider1.Clear();
                txtName.TabStop = true;
                mxtDob.TabStop = true;
                txtAddress.TabStop = true;
                txtcity.TabStop = true;
                cbCountry.TabStop = true;
                txtQualifycation.TabStop = true;
                mtPhone.TabStop = true;
                txtEmail.TabStop = true;
                dtPicker.TabStop = true;
                btnSubmit.TabStop = true;
                btnExit.TabStop = true;
            }
            else
            {
                this.errorProvider1.SetError(ctr, "Khong duoc bo trong");
                txtName.TabStop = true;
                mxtDob.TabStop = false;
                txtAddress.TabStop = false;
                txtcity.TabStop = false;
                cbCountry.TabStop = true;
                txtQualifycation.TabStop = false;
                mtPhone.TabStop = false;
                txtEmail.TabStop = false;
                dtPicker.TabStop = false;
                btnSubmit.TabStop = false;
                btnExit.TabStop = false;
            }
        }

        private void txtQualifycation_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0)
            {
                this.errorProvider1.Clear();
                txtName.TabStop = true;
                mxtDob.TabStop = true;
                txtAddress.TabStop = true;
                txtcity.TabStop = true;
                cbCountry.TabStop = true;
                txtQualifycation.TabStop = true;
                mtPhone.TabStop = true;
                txtEmail.TabStop = true;
                dtPicker.TabStop = true;
                btnSubmit.TabStop = true;
                btnExit.TabStop = true;
            }
            else
            {
                this.errorProvider1.SetError(ctr, "Khong duoc bo trong");
                txtName.TabStop = true;
                mxtDob.TabStop = false;
                txtAddress.TabStop = false;
                txtcity.TabStop = false;
                cbCountry.TabStop = false;
                txtQualifycation.TabStop = true;
                mtPhone.TabStop = false;
                txtEmail.TabStop = false;
                dtPicker.TabStop = false;
                btnSubmit.TabStop = false;
                btnExit.TabStop = false;
            }
        }

        private void mtPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0)
            {
                this.errorProvider1.Clear();
                txtName.TabStop = true;
                mxtDob.TabStop = true;
                txtAddress.TabStop = true;
                txtcity.TabStop = true;
                cbCountry.TabStop = true;
                txtQualifycation.TabStop = true;
                mtPhone.TabStop = true;
                txtEmail.TabStop = true;
                dtPicker.TabStop = true;
                btnSubmit.TabStop = true;
                btnExit.TabStop = true;
            }
            else
            {
                this.errorProvider1.SetError(ctr, "Khong duoc bo trong");
                txtName.TabStop = true;
                mxtDob.TabStop = false;
                txtAddress.TabStop = false;
                txtcity.TabStop = false;
                cbCountry.TabStop = false;
                txtQualifycation.TabStop = false;
                mtPhone.TabStop = true;
                txtEmail.TabStop = false;
                dtPicker.TabStop = false;
                btnSubmit.TabStop = false;
                btnExit.TabStop = false;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0)
            {
                this.errorProvider1.Clear();
                txtName.TabStop = true;
                mxtDob.TabStop = true;
                txtAddress.TabStop = true;
                txtcity.TabStop = true;
                cbCountry.TabStop = true;
                txtQualifycation.TabStop = true;
                mtPhone.TabStop = true;
                txtEmail.TabStop = true;
                dtPicker.TabStop = true;
                btnSubmit.TabStop = true;
                btnExit.TabStop = true;
            }
            else
            {
                this.errorProvider1.SetError(ctr, "Khong duoc bo trong");
                txtName.TabStop = true;
                mxtDob.TabStop = false;
                txtAddress.TabStop = false;
                txtcity.TabStop = false;
                cbCountry.TabStop = false;
                txtQualifycation.TabStop = false;
                mtPhone.TabStop = false;
                txtEmail.TabStop = true;
                dtPicker.TabStop = false;
                btnSubmit.TabStop = false;
                btnExit.TabStop = false;
            }
        }

        private void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0)
            {
                this.errorProvider1.Clear();
                txtName.TabStop = true;
                mxtDob.TabStop = true;
                txtAddress.TabStop = true;
                txtcity.TabStop = true;
                cbCountry.TabStop = true;
                txtQualifycation.TabStop = true;
                mtPhone.TabStop = true;
                txtEmail.TabStop = true;
                dtPicker.TabStop = true;
                btnSubmit.TabStop = true;
                btnExit.TabStop = true;
            }
            else
            {
                this.errorProvider1.SetError(ctr, "Khong duoc bo trong");
                txtName.TabStop = true;
                mxtDob.TabStop = false;
                txtAddress.TabStop = false;
                txtcity.TabStop = false;
                cbCountry.TabStop = false;
                txtQualifycation.TabStop = false;
                mtPhone.TabStop = false;
                txtEmail.TabStop = false;
                dtPicker.TabStop = true;
                btnSubmit.TabStop = false;
                btnExit.TabStop = false;
            }
        }
    }
}
