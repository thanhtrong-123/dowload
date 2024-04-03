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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        int khu1 = 50;
        int khu2 = 100;
        int khu3 = 150;
        private void btnXoa_click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                
                if (listView1.SelectedItems.Count > 0)
                {
                    DialogResult r = MessageBox.Show("Ban co muon xoa!!!", "Xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (r == DialogResult.Yes)
                    {
                        listView1.SelectedItems[i].Remove();
                    }
                    
                }
            }
        }

        private void BtnTinhTien_Click(object sender, EventArgs e)
        {
            int dinhmuc = Convert.ToInt32(txtDinhMuc.Text);
            int socu = Convert.ToInt32(txtSoCu.Text);
            txtThanhTien.Text = (dinhmuc * socu).ToString();
            txtTongTien.Text = txtThanhTien.Text;
            double tieuthu1 = (socu / 100) * 720;
            txtTieuThu.Text = tieuthu1.ToString();


            ListViewItem item = new ListViewItem();
            item.Text = txtHoTen.Text;
            item.SubItems.Add(cbKhuVuc.Text);
            item.SubItems.Add(txtDinhMuc.Text);
            item.SubItems.Add(txtTieuThu.Text);
            item.SubItems.Add(txtThanhTien.Text);
            listView1.Items.Add(item);
        }

        private void cbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            for (int i = 0; i < cbKhuVuc.Items.Count; i++)
            {
                if (cbKhuVuc.SelectedItem == cbKhuVuc.Items[0])
                {
                    cbKhuVuc.Text = khu1.ToString();
                    txtDinhMuc.Text = cbKhuVuc.Text;
                }
                if (cbKhuVuc.SelectedItem == cbKhuVuc.Items[1])
                {
                    cbKhuVuc.Text = khu2.ToString();
                    txtDinhMuc.Text = cbKhuVuc.Text;
                }
                if (cbKhuVuc.SelectedItem == cbKhuVuc.Items[2])
                {
                    cbKhuVuc.Text = khu3.ToString();
                    txtDinhMuc.Text = cbKhuVuc.Text;
                }
                
            }
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtDinhMuc.Clear();
            txtSoCu.Clear();
            txtSoMoi.Clear();
            txtTieuThu.Clear();
            txtThanhTien.Clear();
            txtTongTien.Clear();
            txtHoTen.Focus();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban co muon thoat!!!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void BtnTinhTien_Enter(object sender, EventArgs e)
        {
            int dinhmuc = int.Parse(txtDinhMuc.Text);
             int socu = Convert.ToInt32(txtSoCu.Text);
                txtThanhTien.Text = (dinhmuc * socu).ToString();
                txtTongTien.Text = txtThanhTien.Text;
                double tieuthu1 = (socu / 100) * 720;
                txtTieuThu.Text = tieuthu1.ToString();
      
            ListViewItem item = new ListViewItem();
            item.Text = txtHoTen.Text;
            item.SubItems.Add(cbKhuVuc.Text);
            item.SubItems.Add(txtDinhMuc.Text);
            item.SubItems.Add(txtTieuThu.Text);
            item.SubItems.Add(txtThanhTien.Text);
            listView1.Items.Add(item);
        }


        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                this.Close();
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

        }
    }
}
