using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
namespace Ernie
{
    public partial class Admin_control_Form : Form
    {
        public Admin_control_Form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            // 加载用户数据
            LoadUserData();
        }
        private void LoadUserData()
        {
            string connectionString = "server=localhost;user=root;password=root;database=conversation_hospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView3.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("加载用户数据失败: " + ex.Message);
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cmbRole.Text;

            string connectionString = "server=localhost;user=root;password=root;database=conversation_hospital";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO users (username, password, role) VALUES (@username, @password, @role)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("用户添加成功！");
                    LoadUserData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("添加用户失败: " + ex.Message);
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["id"].Value);

                string connectionString = "server=localhost;user=root;password=root;database=conversation_hospital";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM users WHERE id = @id";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", userId);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("用户删除成功！");
                        LoadUserData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("删除用户失败: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的用户！");
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["id"].Value);
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string role = cmbRole.Text;

                string connectionString = "server=localhost;user=root;password=root;database=conversation_hospital";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE users SET username = @username, password = @password, role = @role WHERE id = @id";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password);
                            cmd.Parameters.AddWithValue("@role", role);
                            cmd.Parameters.AddWithValue("@id", userId);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("用户更新成功！");
                        LoadUserData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("更新用户失败: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要更新的用户！");
            }
        }
    }
}
