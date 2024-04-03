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
    public partial class ThongtinKH : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EV7160S\\SQL2012;Initial Catalog=QLBanXe;Integrated Security=True");
        public ThongtinKH()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ThongtinKH_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_TIMKIEMKH";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramanv = new SqlParameter("@MAKH", SqlDbType.NVarChar);
                paramanv.Value = textBox1.Text;
                cmd.Parameters.Add(paramanv);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_UPDATEKH";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramanv = new SqlParameter("@MAKH", SqlDbType.NVarChar);
                paramanv.Value = textBox1.Text;
                cmd.Parameters.Add(paramanv);

                SqlParameter paratennv = new SqlParameter("@TENKH", SqlDbType.NVarChar);
                paratennv.Value = textBox2.Text;
                cmd.Parameters.Add(paratennv);

                SqlParameter parangaysinh = new SqlParameter("@DIACHI", SqlDbType.DateTime);
                parangaysinh.Value = textBox3.Text;
                cmd.Parameters.Add(parangaysinh);


                if (radNam.Checked)
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
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_DELETEKH";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramanv = new SqlParameter("@MAKH", SqlDbType.NVarChar);
                paramanv.Value = textBox1.Text;
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
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_ADDKH";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramanv = new SqlParameter("@MAKH", SqlDbType.NVarChar);
                paramanv.Value = textBox1.Text;
                cmd.Parameters.Add(paramanv);

                SqlParameter paratennv = new SqlParameter("@TENKH", SqlDbType.NVarChar);
                paratennv.Value = textBox2.Text;
                cmd.Parameters.Add(paratennv);

                SqlParameter parangaysinh = new SqlParameter("@DIACHI", SqlDbType.DateTime);
                parangaysinh.Value = textBox3.Text;
                cmd.Parameters.Add(parangaysinh);

                if (radNam.Checked)
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
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThongtinKH_Load(object sender, EventArgs e)
        {

        }
    }
}
