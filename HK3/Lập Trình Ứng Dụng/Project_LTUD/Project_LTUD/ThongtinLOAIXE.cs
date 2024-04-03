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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_LTUD
{
    public partial class ThongtinLOAIXE : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EV7160S\\SQL2012;Initial Catalog=QLBanXe;Integrated Security=True");
        public ThongtinLOAIXE()
        {
            InitializeComponent();
        }
        DataTable LoadDuLieuXe()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_SELECTALLXE";
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
        void LoadDuLieuLOAIXE()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_SELECTALLLOAIXE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ThongtinLOAIXE_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadDuLieuLOAIXE();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_TIMKIEMLOAIXE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paraMaLOAI = new SqlParameter("@MALOAI", SqlDbType.NVarChar);
                paraMaLOAI.Value = textBox4.Text;
                cmd.Parameters.Add(paraMaLOAI);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataGridView1.CurrentCell.RowIndex;
            comboBox1.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
        }

        private void ThongtinLOAIXE_Load(object sender, EventArgs e)
        {
            LoadDuLieuLOAIXE();
            comboBox1.DataSource = LoadDuLieuXe();
           comboBox1.DisplayMember = "TENXE";
            comboBox1.ValueMember = "MAXE";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_ADDLOAIXE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramaloai = new SqlParameter("@MALOAI", SqlDbType.NVarChar);
                paramaloai.Value = comboBox1.Text;
                cmd.Parameters.Add(paramaloai);

                SqlParameter paratenloai = new SqlParameter("@TENLOAI", SqlDbType.Int);
                paratenloai.Value = Convert.ToInt32(textBox2.Text);
                cmd.Parameters.Add(paratenloai);

                SqlParameter parapk = new SqlParameter("@PK", SqlDbType.Int);
                parapk.Value = Convert.ToInt32(textBox3.Text);
                cmd.Parameters.Add(parapk);
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
                LoadDuLieuLOAIXE();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_DELETELOAIXE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramathue = new SqlParameter("@MALOAI", SqlDbType.NVarChar);
                paramathue.Value = comboBox1.Text;
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
                LoadDuLieuLOAIXE();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_UPDATELOAIXE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter paramaloai = new SqlParameter("@MALOAI", SqlDbType.NVarChar);
                paramaloai.Value = comboBox1.Text;
                cmd.Parameters.Add(paramaloai);

                SqlParameter paratenloai = new SqlParameter("@TENLOAI", SqlDbType.Int);
                paratenloai.Value = Convert.ToInt32(textBox2.Text);
                cmd.Parameters.Add(paratenloai);

                SqlParameter parapk = new SqlParameter("@PK", SqlDbType.Int);
                parapk.Value = Convert.ToInt32(textBox3.Text);
                cmd.Parameters.Add(parapk);
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
                LoadDuLieuLOAIXE();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDuLieuLOAIXE();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
