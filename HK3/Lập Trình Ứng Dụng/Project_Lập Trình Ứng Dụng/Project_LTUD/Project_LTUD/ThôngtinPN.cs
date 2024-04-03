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
    public partial class ThôngtinPN : Form
    {
        public ThôngtinPN()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=QLBanXe;Integrated Security=True");
        private void btnthem_Click(object sender, EventArgs e)
        {
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
                paramanv.Value = cbomanv.SelectedValue.ToString();
                cmd.Parameters.Add(paramanv);
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
                LoadDuLieuPN();
            }
        }

        private void ThôngtinPN_Load(object sender, EventArgs e)
        {
            LoadDuLieuPN();
            cbomanv.DataSource = LoadDuLieuNV();
            cbomanv.DisplayMember = "TENNV";
            cbomanv.ValueMember = "MANV";
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
        void LoadDuLieuPN()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_SELECTALLPN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection=conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt=new DataTable();
                da.Fill(dt);
                dgvpn.DataSource=dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvpn_Click(object sender, EventArgs e)
        {
            int dong =dgvpn.CurrentCell.RowIndex;
            txtmapn.Text = dgvpn.Rows[dong].Cells[0].Value.ToString();
            dtpkpn.Value=Convert.ToDateTime(dgvpn.Rows[dong].Cells[1].Value.ToString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_LAYTENNHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter paramanv = new SqlParameter("@MANV", SqlDbType.NVarChar);
            paramanv.Value = dgvpn.Rows[dong].Cells[2].Value.ToString();
            cmd.Parameters.Add(paramanv);
            string s=cmd.ExecuteScalar().ToString();
            cbomanv.Text=s;
            conn.Close();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int dong = dgvpn.CurrentCell.RowIndex;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_DELETEPN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramapn = new SqlParameter("@MAPN", SqlDbType.NVarChar);
                paramapn.Value = dgvpn.Rows[dong].Cells[0].Value.ToString();
                cmd.Parameters.Add(paramapn);
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
                LoadDuLieuPN();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_UPDATEPN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter parapn = new SqlParameter("@MAPN", SqlDbType.NVarChar);
                parapn.Value = txtmapn.Text;
                cmd.Parameters.Add(parapn);

                SqlParameter parangaynhap = new SqlParameter("@NGAYNHAP", SqlDbType.DateTime);
                parangaynhap.Value = dtpkpn.Text;
                cmd.Parameters.Add(parangaynhap);

                SqlParameter paramanv = new SqlParameter("@MANV", SqlDbType.NVarChar);
                paramanv.Value = cbomanv.SelectedValue.ToString();
                cmd.Parameters.Add(paramanv);
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
                LoadDuLieuPN();
            }
        }

        private void ThôngtinPN_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_TIMKIEMPN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter parapn = new SqlParameter("@MAPN", SqlDbType.NVarChar);
                parapn.Value = txttimkiem.Text;
                cmd.Parameters.Add(parapn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvpn.DataSource = dt;
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
            LoadDuLieuPN();
        }

        private void dgvpn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            INPN pn = null;
            if (pn == null || pn.IsDisposed)
            {
                pn = new INPN();
                pn.Show();

            }
            else
            {
                pn.BringToFront();
            }
        }
    }
}
