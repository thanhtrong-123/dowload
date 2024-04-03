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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < lvDanhSach.Items.Count; i++)
            {
                if (lvDanhSach.SelectedItems.Count > 0)
                {
                    txtMSSV.Text = lvDanhSach.SelectedItems[0].Text;
                    txtHoTen.Text = lvDanhSach.SelectedItems[0].SubItems[1].Text;
                    txtDiaChi.Text = lvDanhSach.SelectedItems[0].SubItems[2].Text;
                    dtpNgaySinh.Text = lvDanhSach.SelectedItems[0].SubItems[3].Text;
                    cbLop.Text = lvDanhSach.SelectedItems[0].SubItems[4].Text;
                }
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {

            ListViewItem item = new ListViewItem();
            item.ImageKey = "user.png";
            lvDanhSach.SmallImageList = imageList1;
            item.Text = txtMSSV.Text;
            item.SubItems.Add(txtHoTen.Text);
            item.SubItems.Add(txtDiaChi.Text);
            item.SubItems.Add(dtpNgaySinh.Text.ToString());
            item.SubItems.Add(cbLop.Text);
            lvDanhSach.Items.Add(item);
            txtMSSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtMSSV.Focus();
        }




        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            this.Enabled = true;
            this.contextMenuStrip1.Visible = true;

        }


        private void lagerIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvDanhSach.View = View.LargeIcon;
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvDanhSach.View = View.Details;

        }

        private void contextMenuStrip1_DoubleClick(object sender, EventArgs e)
        {
            contextMenuStrip1.Enabled = true;
            contextMenuStrip1.Show();
        }

        private void lvDanhSach_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Enabled = true;
            this.contextMenuStrip1.Show(this, new Point(e.X, e.Y));
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvDanhSach.View = View.SmallIcon;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvDanhSach.View = View.List;
        }

        private void tiltleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvDanhSach.View = View.Tile;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < lvDanhSach.Items.Count; i++)
            {
                if (lvDanhSach.SelectedItems.Count > 0)
                {
                    lvDanhSach.SelectedItems[i].Remove();
                }
                else
                {
                    MessageBox.Show("Ban da xoa het");
                }
            }
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {

                    lvDanhSach.SelectedItems[0].SubItems[0].Text = txtMSSV.Text;
                    lvDanhSach.SelectedItems[0].SubItems[1].Text = txtHoTen.Text;
                    lvDanhSach.SelectedItems[0].SubItems[2].Text = txtDiaChi.Text;
                    lvDanhSach.SelectedItems[0].SubItems[3].Text = dtpNgaySinh.Text;
                    lvDanhSach.SelectedItems[0].SubItems[4].Text = cbLop.Text;
                
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban co muon thoat!!!", "Eixt", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
