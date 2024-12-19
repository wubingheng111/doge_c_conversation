using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ernie
{
    public partial class Hospital_sum : Form
        //patient_information
    {
        private string connectionString = "server=localhost;user=root;password=root;database=patient_information";
        public Hospital_sum()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM hospitals", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView4.DataSource = dt;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO hospitals (医院名称, 医院地址, 联系电话, 医院等级, 重点科室) VALUES (@name, @address, @phone, @level, @department)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@address", textBox1.Text);
                cmd.Parameters.AddWithValue("@phone", txtSpecialty.Text);
                cmd.Parameters.AddWithValue("@level", txtHospital.Text);
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text);
                cmd.ExecuteNonQuery();
                LoadData();
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE hospitals SET 医院名称=@name, 医院地址=@address, 联系电话=@phone, 医院等级=@level, 重点科室=@department WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", dataGridView4.SelectedRows[0].Cells[0].Value);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@address", textBox1.Text);
                cmd.Parameters.AddWithValue("@phone", txtSpecialty.Text);
                cmd.Parameters.AddWithValue("@level", txtHospital.Text);
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text);
                cmd.ExecuteNonQuery();
                LoadData();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM hospitals WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", dataGridView4.SelectedRows[0].Cells[0].Value);
                cmd.ExecuteNonQuery();
                LoadData();
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM hospitals WHERE 医院名称 LIKE @name";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@name", "%" + textBox2.Text + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView4.DataSource = dt;
            }
        }
    }
}
