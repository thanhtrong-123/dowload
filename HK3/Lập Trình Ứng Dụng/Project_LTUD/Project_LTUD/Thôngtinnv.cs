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
    public partial class Thôngtinnv : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EV7160S\\SQL2012;Initial Catalog=QLBanXe;Integrated Security=True");
        public Thôngtinnv()
        {
            InitializeComponent();
        }

        private void Thôngtinnv_Load(object sender, EventArgs e)
        {
            LoadDuLieuNV();
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
        void LoadDuLieuNV()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_SELECTALLNV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvnv.DataSource = dt;
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
                cmd.CommandText = "SP_ADDNV";
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramanv = new SqlParameter("@MANV", SqlDbType.NVarChar);
                paramanv.Value = txtmanv.Text;
                cmd.Parameters.Add(paramanv);

                SqlParameter paratennv = new SqlParameter("@TENNV", SqlDbType.NVarChar);
                paratennv.Value = txttennv.Text;
                cmd.Parameters.Add(paratennv);

                if(radnam.Checked)
                {
                    SqlParameter paraphai = new SqlParameter("@PHAI", SqlDbType.NVarChar);
                    paraphai.Value = "Nam";
                    cmd.Parameters.Add(paraphai);
                }
                else
                {
                    SqlParameter paraphai = new SqlParameter("@PHAI", SqlDbType.NVarChar);
                    paraphai.Value = "Nữ";
                    cmd.Parameters.Add(paraphai);
                }

                SqlParameter parangaysinh = new SqlParameter("@NGAYSINH", SqlDbType.DateTime);
                parangaysinh.Value = dtpknv.Text;
                cmd.Parameters.Add(parangaysinh);

                SqlParameter paraluong = new SqlParameter("@LUONG", SqlDbType.Int);
                paraluong.Value = Convert.ToInt32(txtluong.Text);
                cmd.Parameters.Add(paraluong);

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
                LoadDuLieuNV();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_DELETENV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramanv = new SqlParameter("@MANV", SqlDbType.NVarChar);
                paramanv.Value = txtmanv.Text;
                cmd.Parameters.Add(paramanv);
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
                LoadDuLieuNV();
            }

        }

        private void dgvnv_Click(object sender, EventArgs e)
        {
            int dong = dgvnv.CurrentCell.RowIndex;
            txtmanv.Text = dgvnv.Rows[dong].Cells[0].Value.ToString();
            txttennv.Text = dgvnv.Rows[dong].Cells[1].Value.ToString();
            if(dgvnv.Rows[dong].Cells[2].Value.ToString() == "Nam")
            {
                radnam.Checked = true;
            }
            else
            {
                radnu.Checked = true;
            }
            dtpknv.Text = dgvnv.Rows[dong].Cells[3].Value.ToString();
            txtluong.Text = dgvnv.Rows[dong].Cells[4].Value.ToString();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_LAYTENLOAI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter paramaloai = new SqlParameter("@MALOAI", SqlDbType.NVarChar);
            paramaloai.Value = dgvnv.Rows[dong].Cells[5].Value.ToString();
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
                cmd.CommandText = "SP_UPDATENV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramanv = new SqlParameter("@MANV", SqlDbType.NVarChar);
                paramanv.Value = txtmanv.Text;
                cmd.Parameters.Add(paramanv);

                SqlParameter paratennv = new SqlParameter("@TENNV", SqlDbType.NVarChar);
                paratennv.Value = txttennv.Text;
                cmd.Parameters.Add(paratennv);

                if (radnam.Checked)
                {
                    SqlParameter paraphai = new SqlParameter("@PHAI", SqlDbType.NVarChar);
                    paraphai.Value = "Nam";
                    cmd.Parameters.Add(paraphai);
                }
                else
                {
                    SqlParameter paraphai = new SqlParameter("@PHAI", SqlDbType.NVarChar);
                    paraphai.Value = "Nữ";
                    cmd.Parameters.Add(paraphai);
                }

                SqlParameter parangaysinh = new SqlParameter("@NGAYSINH", SqlDbType.DateTime);
                parangaysinh.Value = dtpknv.Text;
                cmd.Parameters.Add(parangaysinh);

                SqlParameter paraluong = new SqlParameter("@LUONG", SqlDbType.Int);
                paraluong.Value = Convert.ToInt32(txtluong.Text);
                cmd.Parameters.Add(paraluong);

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
                LoadDuLieuNV();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Thôngtinnv_FormClosing(object sender, FormClosingEventArgs e)
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
                cmd.CommandText = "SP_TIMKIEMNV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection=conn;
                SqlParameter paramanv = new SqlParameter("@MANV", SqlDbType.NVarChar);
                paramanv.Value = txtmanv.Text;
                cmd.Parameters.Add(paramanv);
                SqlDataAdapter da=new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvnv.DataSource= dt;
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
            LoadDuLieuNV();
        }
    }
}
