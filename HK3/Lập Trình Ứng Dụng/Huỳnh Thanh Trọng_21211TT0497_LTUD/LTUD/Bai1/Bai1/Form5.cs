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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            ListViewItem item = new ListViewItem();
            item.Text = txtFirstName.Text;
            item.ImageKey = "user.png";
            lvAdd.SmallImageList = imageList1;
            ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem(item, txtLastName.Text);
            item.SubItems.Add(subitem1);
            ListViewItem.ListViewSubItem subitem2 = new ListViewItem.ListViewSubItem(item, txtPhone.Text);
            item.SubItems.Add(subitem2);
            lvAdd.Items.Add(item);
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtLastName.Focus();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsLetter(ctr.Text, ctr.Text.Length - 1))
            {
                this.errorProvider1.SetError(ctr, "Ban phai nhap chu va khong duoc de trong");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsLetter(ctr.Text, ctr.Text.Length - 1))
            {
                this.errorProvider1.SetError(ctr, "Ban phai nhap chu va khong duoc de trong");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                this.errorProvider1.SetError(ctr, "Ban phai nhap so va khong duoc de trong");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvAdd.View = View.Details;
            Custom.Text = lvAdd.View.ToString();

        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvAdd.View = View.Tile;
            Custom.Text = lvAdd.View.ToString();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvAdd.View = View.List;
            Custom.Text = lvAdd.View.ToString();
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvAdd.View = View.LargeIcon;
            Custom.Text = lvAdd.View.ToString();
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvAdd.BackColor = Color.Black;
            lvAdd.ForeColor = Color.White;
        }

        private void lvAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvAdd.View = View.SmallIcon;
            Custom.Text = lvAdd.View.ToString();
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvAdd.BackColor = Color.White;
            lvAdd.ForeColor = Color.Black;
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color cl = colorDialog1.Color;
                lvAdd.BackColor = cl;
            }
        }

        private void fontCustomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color cl = colorDialog1.Color;
                lvAdd.ForeColor = cl;
            }
        }
    }
}
