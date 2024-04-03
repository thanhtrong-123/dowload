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

namespace ôn_LTUD
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EV7160S\\SQL2012;Initial Catalog=QLSinhVien;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            LoadDuLieuSinhVien();
        }

        void LoadDuLieuSinhVien()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_SELECTALLSINHVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dgvSinhVien.DataSource = dt;
            conn.Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_ADDSINHVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paraMSSV = new SqlParameter("@MSSV", SqlDbType.NVarChar);
                paraMSSV.Value = txtMSSV.Text;
                cmd.Parameters.Add(paraMSSV);

                SqlParameter paraHoTen = new SqlParameter("@HOTEN", SqlDbType.NVarChar);
                paraHoTen.Value = txtHoTen.Text;
                cmd.Parameters.Add(paraHoTen);

                if (rbNam.Checked)
                {
                    SqlParameter paraPhai = new SqlParameter("@PHAI", SqlDbType.NVarChar);
                    paraPhai.Value = "Nam";
                    cmd.Parameters.Add(paraPhai);
                }
                else
                {
                    SqlParameter paraPhai = new SqlParameter("@PHAI", SqlDbType.NVarChar);
                    paraPhai.Value = "Nữ";
                    cmd.Parameters.Add(paraPhai);
                }

                SqlParameter paraNgaySinh = new SqlParameter("@NGAYSINH", SqlDbType.DateTime);
                paraNgaySinh.Value = dtpNgaySinh.Text;
                cmd.Parameters.Add(paraNgaySinh);

                //SqlParameter paramaloai = new SqlParameter("@MALOAI", SqlDbType.NVarChar);
                //paramaloai.Value = cboml.SelectedValue.ToString();
                //cmd.Parameters.Add(paramaloai);
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
                LoadDuLieuSinhVien();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_DELETESINHVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paraMSSV = new SqlParameter("@MSSV", SqlDbType.NVarChar);
                paraMSSV.Value = txtMSSV.Text;
                cmd.Parameters.Add(paraMSSV);
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
                LoadDuLieuSinhVien();
            }
        }

        private void dgvSinhVien_Click(object sender, EventArgs e)
        {
            int dong = dgvSinhVien.CurrentCell.RowIndex;
            txtMSSV.Text = dgvSinhVien.Rows[dong].Cells[0].Value.ToString();
            txtHoTen.Text = dgvSinhVien.Rows[dong].Cells[1].Value.ToString();
            if (dgvSinhVien .Rows[dong].Cells[2].Value.ToString() == "Nam")
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
            dtpNgaySinh.Text = dgvSinhVien.Rows[dong].Cells[3].Value.ToString();
            //conn.Open();
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "SP_LAYTENLOAI";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Connection = conn;
            //SqlParameter paramaloai = new SqlParameter("@MALOAI", SqlDbType.NVarChar);
            //paramaloai.Value = dgvnv.Rows[dong].Cells[5].Value.ToString();
            //cmd.Parameters.Add(paramaloai);
            //cboml.Text = cmd.ExecuteScalar().ToString();
            conn.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_UPDATESINHVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paraMSSV = new SqlParameter("@MSSV", SqlDbType.NVarChar);
                paraMSSV.Value = txtMSSV.Text;
                cmd.Parameters.Add(paraMSSV);

                SqlParameter paraHoTen = new SqlParameter("@HOTEN", SqlDbType.NVarChar);
                paraHoTen.Value = txtHoTen.Text;
                cmd.Parameters.Add(paraHoTen);

                if (rbNam.Checked)
                {
                    SqlParameter paraPhai = new SqlParameter("@PHAI", SqlDbType.NVarChar);
                    paraPhai.Value = "Nam";
                    cmd.Parameters.Add(paraPhai);
                }
                else
                {
                    SqlParameter paraPhai = new SqlParameter("@PHAI", SqlDbType.NVarChar);
                    paraPhai.Value = "Nữ";
                    cmd.Parameters.Add(paraPhai);
                }

                SqlParameter parangaysinh = new SqlParameter("@NGAYSINH", SqlDbType.DateTime);
                parangaysinh.Value = dtpNgaySinh.Text;
                cmd.Parameters.Add(parangaysinh);


                //SqlParameter paramaloai = new SqlParameter("@MALOAI", SqlDbType.NVarChar);
                //paramaloai.Value = cboml.SelectedValue.ToString();
                //cmd.Parameters.Add(paramaloai);
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
                LoadDuLieuSinhVien();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thật sự muốn THOÁT không?", "THOÁT", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_TIMKIEMSINHVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paraMSSV = new SqlParameter("@MSSV", SqlDbType.NVarChar);
                paraMSSV.Value = txtTim.Text;
                cmd.Parameters.Add(paraMSSV);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSinhVien.DataSource = dt;
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
    }
}
