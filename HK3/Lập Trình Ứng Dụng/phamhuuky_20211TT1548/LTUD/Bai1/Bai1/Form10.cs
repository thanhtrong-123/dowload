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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Nodes.Count > 2)
            {
                MessageBox.Show("Ban khong the them danh muc nay duoc");
            }
            else
            {
                TreeNode tn = new TreeNode(txtMSV.Text + "-" + txtHoTen.Text);
                tn.Nodes.Add(txtDiaChi.Text);
                treeView1.SelectedNode.Nodes.Add(tn);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < treeView1.Nodes.Count; i++)
            {
                if (treeView1.SelectedNode.Nodes.Count > 2 || treeView1.SelectedNode.Nodes.Count == 0 || treeView1.SelectedNode.Nodes.Count > 1)
                {
                    MessageBox.Show("Ban khong the xoa duoc");

                }
                else
                {
                    treeView1.Nodes.Remove(treeView1.SelectedNode);
                }
            }
           
           
        }

        private void txtMSV_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length == 0 || ctr.Text == txtMSV.Text)
            {
                this.errorProvider1.SetError(ctr, "khong duoc de trong va trung ten");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length == 0)
            {
                this.errorProvider1.SetError(ctr, "khong duoc de trong");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length == 0)
            {
                this.errorProvider1.SetError(ctr, "khong duoc de trong");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
    }
}
