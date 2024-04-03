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
    public partial class Thôngtinxe : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EV7160S\\SQL2012;Initial Catalog=QLBanXe;Integrated Security=True");
        public Thôngtinxe()
        {
            InitializeComponent();
        }


        private void Thôngtinxe_Load(object sender, EventArgs e)
        {
            LoadDuLieuXe();
            cboml.DataSource = LoadDuLieuLoaiXe();
            cboml.DisplayMember = "TENLOAI";
            cboml.ValueMember = "MALOAI";
        }
        DataTable LoadDuLieuLoaiXe()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_SELECTALLLOAIXE";
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
        void LoadDuLieuXe()
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

        private void btnthem_Click(object sender, EventArgs e)
        {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SP_ADDXE";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlParameter paramaxe = new SqlParameter("@MAXE", SqlDbType.NVarChar);
                    paramaxe.Value = txtmaxe.Text;
                    cmd.Parameters.Add(paramaxe);

                    SqlParameter paratenxe = new SqlParameter("@TENXE", SqlDbType.NVarChar);
                    paratenxe.Value = txttenxe.Text;
                    cmd.Parameters.Add(paratenxe);

                    SqlParameter paragia = new SqlParameter("@GIA", SqlDbType.Int);
                    paragia.Value = Convert.ToInt32(txtgia.Text);
                    cmd.Parameters.Add(paragia);

                    SqlParameter parasl = new SqlParameter("@SL", SqlDbType.Int);
                    parasl.Value = Convert.ToInt32(txtsl.Text);
                    cmd.Parameters.Add(parasl);

                    SqlParameter paranamsx = new SqlParameter("@NAMSX", SqlDbType.Int);
                    paranamsx.Value = Convert.ToInt32(txtnamsx.Text);
                    cmd.Parameters.Add(paranamsx);

                    SqlParameter paranoisx = new SqlParameter("@NOISX", SqlDbType.NVarChar);
                    paranoisx.Value = txtnoisx.Text;
                    cmd.Parameters.Add(paranoisx);

                    SqlParameter paramaloai = new SqlParameter("@MALOAI", SqlDbType.NVarChar);
                    paramaloai.Value = cboml.SelectedValue.ToString();
                    cmd.Parameters.Add(paramaloai);
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
                    LoadDuLieuXe();
                }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int dong = dgvxe.CurrentCell.RowIndex;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_DELETEXE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramaxe = new SqlParameter("@MAXE", SqlDbType.NVarChar);
                paramaxe.Value = dgvxe.Rows[dong].Cells[0].Value.ToString();
                cmd.Parameters.Add(paramaxe);
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
                LoadDuLieuXe();
            }
        }

        private void dgvxe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvxe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dgvxe.CurrentCell.RowIndex;
            txtmaxe.Text = dgvxe.Rows[dong].Cells[0].Value.ToString();
            txttenxe.Text = dgvxe.Rows[dong].Cells[1].Value.ToString();
            txtgia.Text = dgvxe.Rows[dong].Cells[2].Value.ToString();
            txtsl.Text = dgvxe.Rows[dong].Cells[3].Value.ToString();
            txtnamsx.Text = dgvxe.Rows[dong].Cells[4].Value.ToString();       
            txtnoisx.Text = dgvxe.Rows[dong].Cells[5].Value.ToString();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_LAYTENLOAI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter paramaloai = new SqlParameter("@MALOAI", SqlDbType.NVarChar);
            paramaloai.Value=dgvxe.Rows[dong].Cells[6].Value.ToString();
            cmd.Parameters.Add(paramaloai);
            cboml.Text = cmd.ExecuteScalar().ToString();
            conn.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_UPDATEXE";
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramaxe = new SqlParameter("@MAXE", SqlDbType.NVarChar);
                paramaxe.Value = txtmaxe.Text;
                cmd.Parameters.Add(paramaxe);
                SqlParameter paratenxe = new SqlParameter("@TENXE", SqlDbType.NVarChar);
                paratenxe.Value = txttenxe.Text;
                cmd.Parameters.Add(paratenxe);

                SqlParameter paragia = new SqlParameter("@GIA", SqlDbType.Int);
                paragia.Value = Convert.ToInt32(txtgia.Text);
                cmd.Parameters.Add(paragia);

                SqlParameter parasl = new SqlParameter("@SL", SqlDbType.Int);
                parasl.Value = Convert.ToInt32(txtsl.Text);
                cmd.Parameters.Add(parasl);

                SqlParameter paranamsx = new SqlParameter("@NAMSX", SqlDbType.Int);
                paranamsx.Value = Convert.ToInt32(txtnamsx.Text);
                cmd.Parameters.Add(paranamsx);

                SqlParameter paranoisx = new SqlParameter("@NOISX", SqlDbType.NVarChar);
                paranoisx.Value = txtnoisx.Text;
                cmd.Parameters.Add(paranoisx);

                SqlParameter paramaloai = new SqlParameter("@MALOAI", SqlDbType.NVarChar);
                paramaloai.Value = cboml.SelectedValue.ToString();
                cmd.Parameters.Add(paramaloai);
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
                LoadDuLieuXe();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Thôngtinxe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                e.Cancel = false;
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
                paramaxe.Value=txttimkiem.Text;
                cmd.Parameters.Add(paramaxe);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvxe.DataSource=dt;
            }
            catch(Exception ex)
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
            LoadDuLieuXe();
        }
    }
}
