using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_LTUD
{
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=QLBanXe;Integrated Security=True");
        private void BanHang_Load(object sender, EventArgs e)
        {
            
            LoadDuLieuXe1();
            cbotennv.DataSource = LoadDuLieuNV();
            cbotennv.DisplayMember = "TENNV";
            cbotennv.ValueMember = "MANV";
            cbotenxe.DataSource = LoadDuLieuXe();
            cbotenxe.DisplayMember = "TENXE";
            cbotenxe.ValueMember = "MAXE";
            cbotenkh.DataSource = LoadDuLieuKH();
            cbotenkh.DisplayMember = "TENKH";
            cbotenkh.ValueMember = "MAKH";
            LoadDuLieuKM();
        }
        void LoadDuLieuXe1()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_SELECTALLXE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvxe.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        DataTable LoadDuLieuKH()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_SELECTALLKH";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        DataTable LoadDuLieuXe()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_SELECTALLXE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        private void dgvxe_Click(object sender, EventArgs e)
        {
            int dong =dgvxe.CurrentCell.RowIndex;
            cbotenxe.Text = dgvxe.Rows[dong].Cells[1].Value.ToString();
        }

        private void txtsl_TextChanged(object sender, EventArgs e)
        {
            int dong = dgvxe.CurrentCell.RowIndex;
            int thanhtien = 0;
            if (txtsl.Text != "")
            {
                thanhtien = int.Parse(txtsl.Text) * int.Parse(dgvxe.Rows[dong].Cells[2].Value.ToString());
            }
            else
            {
                txttt.Clear();
                return;
            }
            if(cbokm.Text=="")
            {
                txttt.Text = thanhtien.ToString();
            }
            else
            {
                txttt.Text = Giamgia(cbokm.Text, thanhtien).ToString();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_TIMKIEMXE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramaxe = new SqlParameter("@MAXE", SqlDbType.NVarChar);
                paramaxe.Value = txttimkiem.Text;
                cmd.Parameters.Add(paramaxe);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvxe.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnht_Click(object sender, EventArgs e)
        {
            LoadDuLieuXe1();
        }

        private void btnban_Click(object sender, EventArgs e)
        {
            int dem = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_ADDPX";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter parapn = new SqlParameter("@MAPX", SqlDbType.NVarChar);
                parapn.Value = txtmapx.Text;
                cmd.Parameters.Add(parapn);

                SqlParameter parangaynhap = new SqlParameter("@NGAYXUAT", SqlDbType.DateTime);
                parangaynhap.Value = dtpkpn.Text;
                cmd.Parameters.Add(parangaynhap);

                SqlParameter paramanv = new SqlParameter("@MANV", SqlDbType.NVarChar);
                paramanv.Value = cbotennv.SelectedValue.ToString();
                cmd.Parameters.Add(paramanv);

                SqlParameter paratenkh = new SqlParameter("@MAKH", SqlDbType.NVarChar);
                paratenkh.Value = cbotenkh.SelectedValue.ToString();
                cmd.Parameters.Add(paratenkh);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    dem++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_ADDCTPX";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter paraMaPhieuXuat = new SqlParameter("@MAPX", SqlDbType.NVarChar);
                paraMaPhieuXuat.Value = txtmapx.Text;
                cmd.Parameters.Add(paraMaPhieuXuat);

                SqlParameter paraMaXe = new SqlParameter("@MAXE", SqlDbType.NVarChar);
                paraMaXe.Value = cbotenxe.SelectedValue.ToString();
                cmd.Parameters.Add(paraMaXe);

                SqlParameter paraSoLuong = new SqlParameter("@SL", SqlDbType.Int);
                paraSoLuong.Value = Convert.ToInt32(txtsl.Text);
                cmd.Parameters.Add(paraSoLuong);

                SqlParameter paraGia = new SqlParameter("@GIA", SqlDbType.Int);
                paraGia.Value = Convert.ToInt32(txttt.Text);
                cmd.Parameters.Add(paraGia);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    dem++;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            if(dem==2)
            {
                MessageBox.Show("Bán thành công");
            }
            else
            {
                MessageBox.Show("Bán không thành công");
            }    
        }
        int Giamgia(string makm, int thanhtien)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_LAYPHANTRAMKM";
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter paramakm = new SqlParameter("@MAKM", SqlDbType.NVarChar);
            paramakm.Value= makm;
            cmd.Parameters.Add(paramakm);
            double phantram=int.Parse(cmd.ExecuteScalar().ToString());
            thanhtien = (int)(thanhtien - thanhtien * (phantram / 100));
            conn.Close();
            return thanhtien;
        }
        DataTable LoadDuLieuNV()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_SELECTALLNV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }


        private void cbotenxe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_LAYMAKM";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paraMaXe = new SqlParameter("@MAXE", SqlDbType.NVarChar);
                paraMaXe.Value = cbotenxe.SelectedValue.ToString();
                cmd.Parameters.Add(paraMaXe);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cbokm.DataSource = dt;
                    cbokm.DisplayMember = "MAKM";
                    cbokm.ValueMember = "MAKM";
                }
                else
                {
                    cbokm.Text = "";
                    cbokm.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }           
        }
        void LoadDuLieuKM()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_LAYMAKM";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paraMaXe = new SqlParameter("@MAXE", SqlDbType.NVarChar);
                paraMaXe.Value = cbotenxe.SelectedValue.ToString();
                cmd.Parameters.Add(paraMaXe);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cbokm.DataSource = dt;
                    cbokm.DisplayMember = "MAKM";
                    cbokm.ValueMember = "MAKM";
                }
                else
                {
                    cbokm.Text = "";
                    cbokm.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnInHDBan_Click(object sender, EventArgs e)
        {
            INHDBAN bh = null;
            if (bh  == null || bh.IsDisposed)
            {
                bh = new INHDBAN();
                bh.Show();
                
            }
            else
            {
                bh.BringToFront();
            }
        }
    }
}
