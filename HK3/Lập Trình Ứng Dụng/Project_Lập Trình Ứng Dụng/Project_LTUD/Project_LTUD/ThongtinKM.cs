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
    public partial class ThongtinKM : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=QLBanXe;Integrated Security=True");
        public ThongtinKM()
        {
            InitializeComponent();
        }
        private void ThongtinKM_Load(object sender, EventArgs e)
        {
            LoadDuLieuKM();
            cbMaXe.DataSource = LoadDuLieuXe();
            cbMaXe.DisplayMember = "TENXE";
            cbMaXe.ValueMember = "MAXE";
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
        void LoadDuLieuKM()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_SELECTALLKM";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKM.DataSource = dt;
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
                cmd.CommandText = "SP_ADDKM";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter paraMaKM = new SqlParameter("@MAKM", SqlDbType.NVarChar);
                paraMaKM.Value = txtMaKhuyenMai.Text;
                cmd.Parameters.Add(paraMaKM);

                SqlParameter paraPhanTramKM = new SqlParameter("@PHANTRAMKM", SqlDbType.Int);
                paraPhanTramKM.Value = Convert.ToInt32(txtPhanTramKhuyenMai.Text);
                cmd.Parameters.Add(paraPhanTramKM);

                SqlParameter paraNgayHH = new SqlParameter("@NGAYHH", SqlDbType.DateTime);
                paraNgayHH.Value = txpkNgayHH.Text;
                cmd.Parameters.Add(paraNgayHH);

                SqlParameter paraMaXe = new SqlParameter("@MAXE", SqlDbType.NVarChar);
                paraMaXe.Value = cbMaXe.SelectedValue.ToString();
                cmd.Parameters.Add(paraMaXe);

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
                LoadDuLieuKM();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int dong = dgvKM.CurrentCell.RowIndex;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_DELETEKM";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paraMaKM = new SqlParameter("@MAKM", SqlDbType.NVarChar);
                paraMaKM.Value = dgvKM.Rows[dong].Cells[0].Value.ToString();
                cmd.Parameters.Add(paraMaKM);
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
                LoadDuLieuKM();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_UPDATEKM";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter paraMaKM = new SqlParameter("@MAKM", SqlDbType.NVarChar);
                paraMaKM.Value = txtMaKhuyenMai.Text;
                cmd.Parameters.Add(paraMaKM);

                
                SqlParameter paraPhanTramKM = new SqlParameter("@PHANTRAMKM", SqlDbType.Int);
                paraPhanTramKM.Value = Convert.ToInt32(txtPhanTramKhuyenMai.Text);
                cmd.Parameters.Add(paraPhanTramKM);

                SqlParameter paraNgayHH = new SqlParameter("@NGAYHH", SqlDbType.DateTime);
                paraNgayHH.Value = txpkNgayHH.Text;
                cmd.Parameters.Add(paraNgayHH);

                SqlParameter paraMaXe = new SqlParameter("@MAXE", SqlDbType.NVarChar);
                paraMaXe.Value = cbMaXe.SelectedValue.ToString();
                cmd.Parameters.Add(paraMaXe);
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
                LoadDuLieuKM();
            }
        }

        private void dgvKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dgvKM.CurrentCell.RowIndex;
            txtMaKhuyenMai.Text = dgvKM.Rows[dong].Cells[0].Value.ToString();
            txtPhanTramKhuyenMai.Text = dgvKM.Rows[dong].Cells[2].Value.ToString();
            txpkNgayHH.Text = dgvKM.Rows[dong].Cells[1].Value.ToString();

            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "SP_LAYTENXE";
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Connection = conn;
            SqlParameter paraMaXe = new SqlParameter("@MAXE", SqlDbType.NVarChar);
            paraMaXe.Value = dgvKM.Rows[dong].Cells[3].Value.ToString();
            cmd1.Parameters.Add(paraMaXe);
            cbMaXe.Text = cmd1.ExecuteScalar().ToString();
            conn.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongtinKM_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_TIMKIEMKM";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paraMaKM = new SqlParameter("@MAKM", SqlDbType.NVarChar);
                paraMaKM.Value = txtTim.Text;
                cmd.Parameters.Add(paraMaKM);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKM.DataSource = dt;
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

        private void btnHienThiDanhSachKM_Click(object sender, EventArgs e)
        {
            LoadDuLieuKM();
        }

        private void dgvKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            INKM km = null;
            if (km == null || km.IsDisposed)
            {
                km = new INKM();
                km.Show();

            }
            else
            {
                km.BringToFront();
            }
        }
    }
}
