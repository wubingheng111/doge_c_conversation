using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ernie
{
    public partial class Online_docotor_search : Form
    {
        private string connectionString = "server=localhost;user=root;password=root;database=patient_information";

        public Online_docotor_search()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchDoctor(txtName.Text);
        }
    }
}
