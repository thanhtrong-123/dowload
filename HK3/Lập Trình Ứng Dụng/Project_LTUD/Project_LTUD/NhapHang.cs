using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_LTUD
{
    public partial class NhapHang : Form
    {
        public NhapHang()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EV7160S\\SQL2012;Initial Catalog=QLBanXe;Integrated Security=True");
        private void NhapHang_Load(object sender, EventArgs e)
        {
            LoadDuLieuXe1();
            cbotenxe.DataSource = LoadDuLieuXe();
            cbotenxe.DisplayMember = "TENXE";
            cbotenxe.ValueMember = "MAXE";
            cbotencc.DataSource = LoadDuLieuNHACC();
            cbotencc.DisplayMember = "TENNHACC";
            cbotencc.ValueMember = "MANHACC";
            cbotennv.DataSource = LoadDuLieuNV();
            cbotennv.DisplayMember = "TENNV";
            cbotennv.ValueMember = "MANV";
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
        DataTable LoadDuLieuNHACC()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_SELECTALLNHACC";
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

        private void txtsl_TextChanged(object sender, EventArgs e)
        {
            int dong = dgvxe.CurrentCell.RowIndex;
            int thanhtien = int.Parse(txtsl.Text) * int.Parse(dgvxe.Rows[dong].Cells[2].Value.ToString());
            txttt.Text = thanhtien.ToString();
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            int dem = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_ADDPN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter parapn = new SqlParameter("@MAPN", SqlDbType.NVarChar);
                parapn.Value = txtmapn.Text;
                cmd.Parameters.Add(parapn);

                SqlParameter parangaynhap = new SqlParameter("@NGAYNHAP", SqlDbType.DateTime);
                parangaynhap.Value = dtpkpn.Text;
                cmd.Parameters.Add(parangaynhap);

                SqlParameter paramanv = new SqlParameter("@MANV", SqlDbType.NVarChar);
                paramanv.Value = cbotennv.SelectedValue.ToString();
                cmd.Parameters.Add(paramanv);
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
                cmd.CommandText = "SP_ADDCTPN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter paraMaPhieuNhap = new SqlParameter("@MAPN", SqlDbType.NVarChar);
                paraMaPhieuNhap.Value = txtmapn.Text;
                cmd.Parameters.Add(paraMaPhieuNhap);

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
            if (dem == 2)
            {
                MessageBox.Show("Nhập hàng thành công");
            }
            else
            {
                MessageBox.Show("Nhập hàng không thành công");
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhapHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }
    }
}
