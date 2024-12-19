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
namespace Pharmacy_Management_System
{
    public partial class InquireDrugDate : Form
    {
        //用于连接数据库的字符串
        public static string strConn = "Server = localhost;Port = 3306;Database = pharmacy_management;UserID = root;Password = 123456;charset = utf8mb4";
        public InquireDrugDate()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
        }

        private void txtDCTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void InquireDrugDate_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // 获取文本框中的日期
            string date = txtDName.Text.Trim();

            // 如果日期为空，则显示一个消息框并返回
            if (string.IsNullOrEmpty(date))
            {
                MessageBox.Show("请输入日期！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 创建连接对象
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                try
                {
                    // 打开连接
                    conn.Open();

                    // 创建查询命令
                    string query = "SELECT * FROM DrugDateInfomation WHERE drug_name = @Drug_name";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // 使用参数化查询来防止SQL注入
                        cmd.Parameters.AddWithValue("@Drug_name", date);

                        // 执行查询并获取结果
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // 将数据绑定到DataGridView
                            dgvDDate.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 显示错误信息
                    MessageBox.Show("查询药物信息时出错：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtDName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 清空文本框内容
            txtDName.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
