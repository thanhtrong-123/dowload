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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EV7160S\\SQL2012;Initial Catalog=QLSinhVien;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
            HienThiSinhVien();
        }
        void HienThiSinhVien()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_SELECTALLSINHVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dgvSinhVien.DataSource = dt;
            con.Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_ADDSINHVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

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
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them Thanh Cong");
                }
                else
                {
                    MessageBox.Show("Them khong thanh cong");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                HienThiSinhVien();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_DELETESINHVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                SqlParameter paraMSSV = new SqlParameter("@MSSV", SqlDbType.NVarChar);
                paraMSSV.Value = txtMSSV.Text;
                cmd.Parameters.Add(paraMSSV);
                DialogResult dr = MessageBox.Show("ban co muon xoa khong", "co", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if(cmd.ExecuteNonQuery()>0)
                    {
                        MessageBox.Show("xoa thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("xoa khong thanh cong");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("loi", ex.Message);
            }
            finally
            {
                con.Close();
                HienThiSinhVien();
            }
        }

        private void dgvSinhVien_Click(object sender, EventArgs e)
        {
            int dong = dgvSinhVien.CurrentCell.RowIndex;
            txtMSSV.Text = dgvSinhVien.Rows[dong].Cells[0].Value.ToString();
            txtHoTen.Text = dgvSinhVien.Rows[dong].Cells[1].Value.ToString();
            if(dgvSinhVien.Rows[dong].Cells[2].Value.ToString() == "Nam")
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
            dtpNgaySinh.Text = dgvSinhVien.Rows[dong].Cells[3].Value.ToString();
            //con.Open();
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "SP_LAYTEN";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Connection = con;
            //SqlParameter paraMaLoai = new SqlParameter("@MALOAI", SqlDbType.NVarChar);
            //paraMaLoai.Value = dgvSinhVien.Rows[dong].Cells[4].Value.ToString();
            //cmd.Parameters.Add(paraMaLoai);
            //cbMaLoai.Text = cmd.ExecuteScalar().ToString();
            con.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_UPDATESINHVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

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

                if(cmd.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("sua thanh cong");
                }
                else
                {
                    MessageBox.Show("sua khong thanh cong");
                }    

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                HienThiSinhVien();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co muon thoat khong", "co", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_TIMKIEMSINHVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlParameter paraMSSV = new SqlParameter("@MSSV", SqlDbType.NVarChar);
                paraMSSV.Value = txtTim.Text;
                cmd.Parameters.Add(paraMSSV);

                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dgvSinhVien.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                
            }
        }
    }
}
