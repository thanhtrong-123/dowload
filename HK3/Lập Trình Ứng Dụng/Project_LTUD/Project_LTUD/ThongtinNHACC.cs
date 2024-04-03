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
    public partial class ThongtinNHACC : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EV7160S\\SQL2012;Initial Catalog=QLBanXe;Integrated Security=True");
        public ThongtinNHACC()
        {
            InitializeComponent();
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
        void LoadDuLieuNHACC()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_SELECTALLNHACC";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_DELETENHACC";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramathue = new SqlParameter("@MANHACC", SqlDbType.NVarChar);
                paramathue.Value = textBox1.Text;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                LoadDuLieuNHACC();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_ADDNHACC";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramanhacc = new SqlParameter("@MANHACC", SqlDbType.NVarChar);
                paramanhacc.Value = textBox1.Text;
                cmd.Parameters.Add(paramanhacc);

                SqlParameter paratennhacc = new SqlParameter("@TENNHACC", SqlDbType.Int);
                paratennhacc.Value = Convert.ToInt32(textBox2.Text);
                cmd.Parameters.Add(paratennhacc);

                SqlParameter paradiachinhacc = new SqlParameter("@DIACHINCC", SqlDbType.Int);
                paradiachinhacc.Value = Convert.ToInt32(textBox3.Text);
                cmd.Parameters.Add(paradiachinhacc);

                SqlParameter paramapn = new SqlParameter("@MAPN", SqlDbType.NVarChar);
                paramapn.Value = comboBox1.Text;
                cmd.Parameters.Add(paramapn);
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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                LoadDuLieuNHACC();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_UPDATENHACC";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramanhacc = new SqlParameter("@MANHACC", SqlDbType.NVarChar);
                paramanhacc.Value = textBox1.Text;
                cmd.Parameters.Add(paramanhacc);

                SqlParameter paratennhacc = new SqlParameter("@TENNHACC", SqlDbType.Int);
                paratennhacc.Value = Convert.ToInt32(textBox2.Text);
                cmd.Parameters.Add(paratennhacc);

                SqlParameter paradiachinhacc = new SqlParameter("@DIACHINCC", SqlDbType.Int);
                paradiachinhacc.Value = Convert.ToInt32(textBox3.Text);
                cmd.Parameters.Add(paradiachinhacc);

                SqlParameter paramapn = new SqlParameter("@MAPN", SqlDbType.NVarChar);
                paramapn.Value = comboBox1.Text;
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
                LoadDuLieuNHACC();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_TIMKIEMNHACC";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramanhacc = new SqlParameter("@MANHACC", SqlDbType.NVarChar);
                paramanhacc.Value = textBox5.Text;
                cmd.Parameters.Add(paramanhacc);
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

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadDuLieuNHACC();
        }

        private void ThongtinNHACC_Load(object sender, EventArgs e)
        {
            LoadDuLieuNHACC();
            comboBox1.DataSource = LoadDuLieuPN();
            comboBox1.DisplayMember = "MAPN";
            comboBox1.ValueMember = "MAPN";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongtinNHACC_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }
    }
}
