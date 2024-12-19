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
using Pharmacy_Management_System.药品保质期信息;

namespace Pharmacy_Management_System
{
    public partial class DrugDateinfomation : Form
    {
        //用于连接数据库的字符串
        public static string strConn = "Server = localhost;Port = 3306;Database = patient_information ;UserID = root;Password = root;charset = utf8mb4";
        //用于记录在DataGridView控件中指定单元格信息的字段
        public static string str = "";
        public DrugDateinfomation()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DrugDateinfomation_Load(object sender, EventArgs e)
        {
            // 在窗体加载时绑定数据
            ShowInfo();
        }
        private void ShowInfo()
        {
            using (MySqlConnection sqlConnection = new MySqlConnection(strConn))
            {
                DataTable dataTable = new DataTable();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("SELECT id AS 序号, drug_name AS 药品名称, shelf_life_months AS 保质期（月）,production_time AS 生产时间, currenttime AS 当前时间 FROM DrugDateInfomation ORDER BY id", sqlConnection);
                sqlDataAdapter.Fill(dataTable);
                this.dgvDDate.DataSource = dataTable.DefaultView;
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要删除本条信息吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (str != "")
                {
                    using (MySqlConnection sqlConnection = new MySqlConnection(strConn))
                    {
                        sqlConnection.Open();
                        MySqlCommand sqlCommand = new MySqlCommand("delete from DrugDateInfomation where id='" + str +
                            "'", sqlConnection);
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        ShowInfo();
                        MessageBox.Show("删除成功！");
                        // 清空文本框和单选按钮！！！！！！！！！！！！！！！！！
                        // 清空文本框内容
                        txtDNumber.Text = "";
                        txtDName.Text = "";
                        txtDDate.Text = "";
                        datDPTime.Text = "";
                        datDCTime.Text = "";
                    }
                }
            }
        }
        private void FillControls()
        {

            int rowIndex = dgvDDate.CurrentCell.RowIndex;
            this.txtDNumber.Text = dgvDDate.Rows[rowIndex].Cells["序号"].Value.ToString();
            this.txtDName.Text = dgvDDate.Rows[rowIndex].Cells["药品名称"].Value.ToString();
            this.txtDDate.Text = dgvDDate.Rows[rowIndex].Cells["保质期（月）"].Value.ToString();
            this.datDPTime.Text = dgvDDate.Rows[rowIndex].Cells["生产时间"].Value.ToString();
            this.datDCTime.Text = dgvDDate.Rows[rowIndex].Cells["当前时间"].Value.ToString();

        }

        private void dgvDDate_Click(object sender, EventArgs e)
        {
            str = this.dgvDDate.SelectedCells[0].Value.ToString();
            FillControls();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 清空文本框内容
            txtDNumber.Text = "";
            txtDName.Text = "";
            txtDDate.Text = "";
            datDPTime.Text = "";
            datDCTime.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDDate.SelectedCells.Count > 0)
            {
                int rowIndex = dgvDDate.SelectedCells[0].RowIndex;
                string id = dgvDDate.Rows[rowIndex].Cells["序号"].Value.ToString();
                string drugName = dgvDDate.Rows[rowIndex].Cells["药品名称"].Value.ToString();
                string months = dgvDDate.Rows[rowIndex].Cells["保质期（月）"].Value.ToString();
                string productionTime = dgvDDate.Rows[rowIndex].Cells["生产时间"].Value.ToString();
                string currentTime = dgvDDate.Rows[rowIndex].Cells["当前时间"].Value.ToString();

                UpdateDrugDate update = new UpdateDrugDate();
                update.LoadData(id, drugName, months, productionTime, currentTime);
                update.ShowDialog(); // 显示更新窗体
            }
            else
            {
                MessageBox.Show("请先选择一个药品记录。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInquire_Click(object sender, EventArgs e)
        {
            InquireDrugDate inquireDrugDate = new InquireDrugDate();
            inquireDrugDate.Show();
        }

        private void btnDataUpdate_Click(object sender, EventArgs e)
        {
            ShowInfo1();
        }
        private void ShowInfo1()
        {
            using (MySqlConnection sqlConnection = new MySqlConnection(strConn))
            {
                DataTable dataTable = new DataTable();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("SELECT id AS 序号, drug_name AS 药品名称, shelf_life_months AS 保质期（月）,production_time AS 生产时间, currenttime AS 当前时间 FROM DrugDateInfomation ORDER BY id", sqlConnection);
                try
                {
                    sqlConnection.Open();
                    sqlDataAdapter.Fill(dataTable);
                    this.dgvDDate.DataSource = dataTable.DefaultView;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("数据库连接失败：" + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                    sqlConnection.Dispose();
                }
            }
        }
    }
}
