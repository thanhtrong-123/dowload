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
        SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=QLBanXe;Integrated Security=True");
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
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            LoadDuLieuKH();
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
                paramanv.Value = textBox4.Text;
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
                SqlParameter paramakh = new SqlParameter("@MAKH", SqlDbType.NVarChar);
                paramakh.Value = textBox1.Text;
                cmd.Parameters.Add(paramakh);

                SqlParameter paratenkh = new SqlParameter("@TENKH", SqlDbType.NVarChar);
                paratenkh.Value = textBox2.Text;
                cmd.Parameters.Add(paratenkh);

                SqlParameter paradiachi = new SqlParameter("@DIACHI", SqlDbType.NVarChar);
                paradiachi.Value = textBox3.Text;
                cmd.Parameters.Add(paradiachi);


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
                LoadDuLieuKH();
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
                LoadDuLieuKH();
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
                SqlParameter paramakh = new SqlParameter("@MAKH", SqlDbType.NVarChar);
                paramakh.Value = textBox1.Text;
                cmd.Parameters.Add(paramakh);

                SqlParameter paratenkh = new SqlParameter("@TENKH", SqlDbType.NVarChar);
                paratenkh.Value = textBox2.Text;
                cmd.Parameters.Add(paratenkh);

                SqlParameter paradiachi = new SqlParameter("@DIACHI", SqlDbType.NVarChar);
                paradiachi.Value = textBox3.Text;
                cmd.Parameters.Add(paradiachi);

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
                LoadDuLieuKH();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThongtinKH_Load(object sender, EventArgs e)
        {
            LoadDuLieuKH();
        }
        void LoadDuLieuKH()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_SELECTALLKH";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int dong = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            if (dataGridView1.Rows[dong].Cells[3].Value.ToString()=="Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            INKH kh = null;
            if (kh == null || kh.IsDisposed)
            {
                kh = new INKH();
                kh.Show();

            }
            else
            {
                kh.BringToFront();
            }
        }
    }
}
