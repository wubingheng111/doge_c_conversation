using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ernie
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100); 
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("用户名和密码不能为空。");
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入。");
                return;
            }

            string connectionString = "server=localhost;database=conversation_hospital;user=root;password=root;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string role = "user"; // 只能注册用户账号
                    string query = "INSERT INTO users (username, password, role) VALUES (@username, @password, @role)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("注册成功！");
                    this.Hide();
                    Login loginForm = new Login();
                    loginForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}
