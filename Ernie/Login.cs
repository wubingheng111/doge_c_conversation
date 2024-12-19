using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ernie
{
    public partial class Login : Form
    {
        private string selectedRole = "user"; // 默认角色为用户

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("用户名和密码不能为空。");
                return;
            }
            string connectionString = "server=localhost;database=conversation_hospital;user=root;password=root;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT role FROM users WHERE username=@username AND password=@password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string role = reader["role"].ToString();
                        this.Hide();

                        if (selectedRole == "admin")
                        {
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                        }
                        else if (selectedRole == "user")
                        {
                            UserForm userForm = new UserForm();
                            userForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("角色不匹配。");
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误。");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误: " + ex.Message);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerForm = new Register();
            registerForm.Show();
        }

        private void residuebutton_Click_user(object sender, EventArgs e)
        {
            selectedRole = "user";
            MessageBox.Show("用户模式已选择");
        }

        private void residuebutton_Click_admin(object sender, EventArgs e)
        {
            selectedRole = "admin";
            MessageBox.Show("管理员模式已选择");
        }
    }
}
