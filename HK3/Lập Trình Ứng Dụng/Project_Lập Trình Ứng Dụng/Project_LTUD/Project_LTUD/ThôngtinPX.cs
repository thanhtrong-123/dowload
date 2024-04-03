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
    public partial class ThôngtinPX : Form
    {
        public ThôngtinPX()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=QLBanXe;Integrated Security=True");

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
        void LoadDuLieuPX()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_SELECTALLPX";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvpx.DataSource = dt;
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
        private void ThôngtinPX_Load(object sender, EventArgs e)
        {
            LoadDuLieuPX();
            cbotennv.DataSource = LoadDuLieuNV();
            cbotennv.DisplayMember = "TENNV";
            cbotennv.ValueMember = "MANV";
            cbotenkh.DataSource = LoadDuLieuKH();
            cbotenkh.DisplayMember = "TENKH";
            cbotenkh.ValueMember = "MAKH";
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_UPDATEPX";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter parapx = new SqlParameter("@MAPX", SqlDbType.NVarChar);
                parapx.Value = txtmapx.Text;
                cmd.Parameters.Add(parapx);

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
                LoadDuLieuPX();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
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
                LoadDuLieuPX();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int dong = dgvpx.CurrentCell.RowIndex;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_DELETEPX";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramapx = new SqlParameter("@MAPX", SqlDbType.NVarChar);
                paramapx.Value = dgvpx.Rows[dong].Cells[0].Value.ToString();
                cmd.Parameters.Add(paramapx);
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
                LoadDuLieuPX();
            }
        }

        private void dgvpx_Click(object sender, EventArgs e)
        {
            int dong = dgvpx.CurrentCell.RowIndex;
            txtmapx.Text = dgvpx.Rows[dong].Cells[0].Value.ToString();
            dtpkpn.Value = Convert.ToDateTime(dgvpx.Rows[dong].Cells[1].Value.ToString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_LAYTENNHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter paramanv = new SqlParameter("@MANV", SqlDbType.NVarChar);
            paramanv.Value = dgvpx.Rows[dong].Cells[2].Value.ToString();
            cmd.Parameters.Add(paramanv);
            string s = cmd.ExecuteScalar().ToString();
            cbotennv.Text = s;

            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "SP_LAYTENKH";
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Connection = conn;
            SqlParameter paratenkh = new SqlParameter("@MAKH", SqlDbType.NVarChar);
            paratenkh.Value = dgvpx.Rows[dong].Cells[3].Value.ToString();
            cmd1.Parameters.Add(paratenkh);
            string s1 = cmd1.ExecuteScalar().ToString();
            cbotenkh.Text = s1;
            conn.Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThôngtinPX_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_TIMKIEMPX";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter parapx = new SqlParameter("@MAPX", SqlDbType.NVarChar);
                parapx.Value = txttimkiem.Text;
                cmd.Parameters.Add(parapx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvpx.DataSource = dt;
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
            LoadDuLieuPX();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            INPX px = null;
            if (px == null || px.IsDisposed)
            {
                px = new INPX();
                px.Show();

            }
            else
            {
                px.BringToFront();
            }
        }
    }
}
