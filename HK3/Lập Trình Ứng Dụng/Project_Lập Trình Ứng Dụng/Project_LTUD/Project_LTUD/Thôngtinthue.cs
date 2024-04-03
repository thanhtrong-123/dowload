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
    public partial class Thôngtinthue : Form
    {
        public Thôngtinthue()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=QLBanXe;Integrated Security=True");
        private void Thôngtinthue_Load(object sender, EventArgs e)
        {
            LoadDuLieuThue();
            cbomapn.DataSource = LoadDuLieuPN();
            cbomapn.DisplayMember = "MAPN";
            cbomapn.ValueMember = "MAPN";

        }
        DataTable LoadDuLieuPN()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_SELECTALLPN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        void LoadDuLieuThue()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_SELECTALLTHUE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection=conn;
                SqlDataAdapter da=new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvthue.DataSource=dt;
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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_DELETETHUE";
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Connection= conn;
                SqlParameter paramathue = new SqlParameter("@MATHUE", SqlDbType.NVarChar);
                paramathue.Value = txtmathue.Text;
                cmd.Parameters.Add(paramathue);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                LoadDuLieuThue();
            }
        }

        private void dgvthue_Click(object sender, EventArgs e)
        {
            int dong = dgvthue.CurrentCell.RowIndex;
            txtmathue.Text = dgvthue.Rows[dong].Cells[0].Value.ToString();
            txtgiathue.Text = dgvthue.Rows[dong].Cells[1].Value.ToString();
            cbomapn.Text = dgvthue.Rows[dong].Cells[2].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_ADDTHUE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramathue = new SqlParameter("@MATHUE", SqlDbType.NVarChar);
                paramathue.Value = txtmathue.Text;
                cmd.Parameters.Add(paramathue);

                SqlParameter paragiathue = new SqlParameter("@GIATHUE", SqlDbType.Int);
                paragiathue.Value = Convert.ToInt32(txtgiathue.Text);
                cmd.Parameters.Add(paragiathue);

                SqlParameter paramapn = new SqlParameter("@MAPN", SqlDbType.NVarChar);
                paramapn.Value = cbomapn.Text;
                cmd.Parameters.Add(paramapn);
                if(cmd.ExecuteNonQuery()>0)
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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                LoadDuLieuThue();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_UPDATETHUE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramathue=new SqlParameter("@MATHUE", SqlDbType.NVarChar);
                paramathue.Value = txtmathue.Text;
                cmd.Parameters.Add(paramathue);

                SqlParameter paragiathue = new SqlParameter("@GIATHUE", SqlDbType.Int);
                paragiathue.Value = Convert.ToInt32(txtgiathue.Text);
                cmd.Parameters.Add(paragiathue);

                SqlParameter paramapn = new SqlParameter("@MAPN", SqlDbType.NVarChar);
                paramapn.Value = cbomapn.Text;
                cmd.Parameters.Add(paramapn);
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
                LoadDuLieuThue();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Thôngtinthue_FormClosing(object sender, FormClosingEventArgs e)
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
                cmd.CommandText = "SP_TIMKIEMTHUE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramathue = new SqlParameter("@MATHUE", SqlDbType.NVarChar);
                paramathue.Value = txttimkiem.Text;
                cmd.Parameters.Add(paramathue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvthue.DataSource = dt;
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
            LoadDuLieuThue();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            INTHUE thue = null;
            if (thue == null || thue.IsDisposed)
            {
                thue = new INTHUE();
                thue.Show();

            }
            else
            {
                thue.BringToFront();
            }
        }
    }
}
