using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_LTUD
{
    public partial class ThongtinCTPX : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EV7160S\\SQL2012;Initial Catalog=QLBanXe;Integrated Security=True");
        public ThongtinCTPX()
        {
            InitializeComponent();
        }

        private void ThongtinCTPX_Load(object sender, EventArgs e)
        {
            LoadDuLieuCTPX();
            cbMaXe.DataSource = LoadDuLieuXe();
            cbMaXe.DisplayMember = "TENXE";
            cbMaXe.ValueMember = "MAXE";

            cbMaPhieuXuat.DataSource = LoadDuLieuPX();
            cbMaPhieuXuat.DisplayMember = "MAPX";
            cbMaPhieuXuat.ValueMember = "MAPX";
        }
        DataTable LoadDuLieuPX()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_SELECTALLPX";
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
        void LoadDuLieuCTPX()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_SELECTALLCTPX";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCTPX.DataSource = dt;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_ADDCTPX";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter paraMaPhieuXuat = new SqlParameter("@MAPX", SqlDbType.NVarChar);
                paraMaPhieuXuat.Value = cbMaPhieuXuat.SelectedValue.ToString();
                cmd.Parameters.Add(paraMaPhieuXuat);

                SqlParameter paraMaXe = new SqlParameter("@MAXE", SqlDbType.NVarChar);
                paraMaXe.Value = cbMaXe.SelectedValue.ToString();
                cmd.Parameters.Add(paraMaXe);

                SqlParameter paraSoLuong = new SqlParameter("@SL", SqlDbType.Int);
                paraSoLuong.Value = Convert.ToInt32(txtSoLuong.Text);
                cmd.Parameters.Add(paraSoLuong);

                SqlParameter paraGia = new SqlParameter("@GIA", SqlDbType.Int);
                paraGia.Value = Convert.ToInt32(txtGia.Text);
                cmd.Parameters.Add(paraGia);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
                LoadDuLieuCTPX();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int dong = dgvCTPX.CurrentCell.RowIndex;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_DELETECTPX";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paraMaPX = new SqlParameter("@MAPX", SqlDbType.NVarChar);
                paraMaPX.Value = dgvCTPX.Rows[dong].Cells[0].Value.ToString();
                cmd.Parameters.Add(paraMaPX);
                SqlParameter paraMaXE = new SqlParameter("@MAXE", SqlDbType.NVarChar);
                paraMaXE.Value = dgvCTPX.Rows[dong].Cells[1].Value.ToString();
                cmd.Parameters.Add(paraMaXE);
                DialogResult r = MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
                LoadDuLieuCTPX();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_UPDATECTPX";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter paraMaPX = new SqlParameter("@MAPX", SqlDbType.NVarChar);
                paraMaPX.Value = cbMaPhieuXuat.SelectedValue.ToString();
                cmd.Parameters.Add(paraMaPX);

                SqlParameter paraMaXe = new SqlParameter("@MAXE", SqlDbType.NVarChar);
                paraMaXe.Value = cbMaXe.SelectedValue.ToString();
                cmd.Parameters.Add(paraMaXe);

                SqlParameter parasl = new SqlParameter("@SL", SqlDbType.Int);
                parasl.Value = Convert.ToInt32(txtSoLuong.Text);
                cmd.Parameters.Add(parasl);

                SqlParameter paragia = new SqlParameter("@GIA", SqlDbType.Int);
                paragia.Value = Convert.ToInt32(txtSoLuong.Text);
                cmd.Parameters.Add(paragia);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
                LoadDuLieuCTPX();
            }
        }

        private void dgvCTPX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dgvCTPX.CurrentCell.RowIndex;
                       
            cbMaPhieuXuat.Text = dgvCTPX.Rows[dong].Cells[0].Value.ToString();
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "SP_LAYTENXE";
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Connection = conn;
            SqlParameter paraMaXe = new SqlParameter("@MAXE", SqlDbType.NVarChar);
            paraMaXe.Value = dgvCTPX.Rows[dong].Cells[1].Value.ToString();
            cmd1.Parameters.Add(paraMaXe);
            cbMaXe.Text = cmd1.ExecuteScalar().ToString();
            txtSoLuong.Text = dgvCTPX.Rows[dong].Cells[2].Value.ToString();
            txtGia.Text = dgvCTPX.Rows[dong].Cells[3].Value.ToString();
            conn.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongtinCTPX_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_TIMKIEMCTPX";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paraMaPX = new SqlParameter("@MAPX", SqlDbType.NVarChar);
                paraMaPX.Value = txtTim.Text;
                cmd.Parameters.Add(paraMaPX);
                SqlParameter paramaxe = new SqlParameter("@MAXE", SqlDbType.NVarChar);
                paramaxe.Value = txttim1.Text;
                cmd.Parameters.Add(paramaxe);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCTPX.DataSource = dt;
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

        private void btnHienThiDanhSach_Click(object sender, EventArgs e)
        {
            LoadDuLieuCTPX();
        }

        private void dgvCTPX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
