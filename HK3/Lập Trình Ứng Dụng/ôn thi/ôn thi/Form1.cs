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
        }
        void LoadDuLieuSinhVien()
        {
            try
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
                cmd.CommandText = "SP_ADDSINHVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paraMSSV = new SqlParameter("@MSSV", SqlDbType.NVarChar);
                paraMSSV.Value = txtMSSV.Text;
                cmd.Parameters.Add(paraMSSV);

                SqlParameter paraHoTen = new SqlParameter("@HOTEN", SqlDbType.NVarChar);
                paraHoTen.Value = txtHoTen.Text;
                cmd.Parameters.Add(paraHoTen);

                if (rbtnNam.Checked)
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
    }
}
