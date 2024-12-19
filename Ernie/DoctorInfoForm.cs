using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ernie
{
    public partial class DoctorInfoForm : Form
    {
        private string connectionString = "server=localhost;user=root;password=root;database=patient_information";

        public DoctorInfoForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            LoadDoctorData();
        }

        private void LoadDoctorData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM doctors";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void AddDoctor(string name, string hospital, string specialty, string department, string title)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO doctors (医生姓名, 医院, 擅长, 科室, 职称) VALUES (@name, @hospital, @specialty, @department, @title)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@hospital", hospital);
                cmd.Parameters.AddWithValue("@specialty", specialty);
                cmd.Parameters.AddWithValue("@department", department);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.ExecuteNonQuery();
            }
            LoadDoctorData();
        }

        private void UpdateDoctor(string name, string hospital, string specialty, string department, string title)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE doctors SET 医院=@hospital, 擅长=@specialty, 科室=@department, 职称=@title WHERE 医生姓名=@name";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@hospital", hospital);
                cmd.Parameters.AddWithValue("@specialty", specialty);
                cmd.Parameters.AddWithValue("@department", department);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.ExecuteNonQuery();
            }
            LoadDoctorData();
        }


        private void DeleteDoctor(string name)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM doctors WHERE 医生姓名=@name";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
            }
            LoadDoctorData();
        }



        private void SearchDoctor(string name)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM doctors WHERE 医生姓名 LIKE @name";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@name", "%" + name + "%");
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDoctor(txtName.Text, txtHospital.Text, txtSpecialty.Text, txtDepartment.Text, txtTitle.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDoctor(txtName.Text, txtHospital.Text, txtSpecialty.Text, txtDepartment.Text, txtTitle.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDoctor(txtName.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchDoctor(txtName.Text);
        }

    }
    }
