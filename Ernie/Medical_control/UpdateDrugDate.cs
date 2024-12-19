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

namespace Pharmacy_Management_System.药品保质期信息
{
    public partial class UpdateDrugDate : Form
    {
        private string strConn = "Server=localhost;Port=3306;Database=pharmacy_management;UserID=root;Password=123456;charset=utf8mb4";
        public string DrugId { get; set; }
        public string DrugName { get; set; }
        public string ShelfLifeMonths { get; set; }
        public string ProductionTime { get; set; }
        public string CurrentTime { get; set; }
        public UpdateDrugDate()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
        }
        public void LoadData(string id, string name, string months, string productionTime, string currentTime)
        {
            DrugId = id;
            DrugName = name;
            ShelfLifeMonths = months;
            ProductionTime = productionTime;
            CurrentTime = currentTime;

            txtDNumber.Text = DrugId;
            txtDName.Text = DrugName;
            txtDDate.Text = ShelfLifeMonths;
            datDPTime.Text = ProductionTime;
            datDCTime.Text = CurrentTime;
        }
        private void UpdateDrugDate_Load(object sender, EventArgs e)
        {

        }

        private void UpdateDrugDate_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string id = txtDNumber.Text; // 直接从文本框获取id
            string drugName = txtDName.Text;
            string shelfLifeMonths = txtDDate.Text;
            string productionTime = datDPTime.Text;
            string currentTime = datDCTime.Text;
            DateTime productionTimeParsed;
            DateTime currentTimeParsed;

            // 尝试解析生产时间，格式应为 "yyyy年MM月dd日" 或 "yyyy年M月d日"
            if (!DateTime.TryParseExact(productionTime, "yyyy年MM月dd日", System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out productionTimeParsed) &&
                !DateTime.TryParseExact(productionTime, "yyyy年M月d日", System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out productionTimeParsed))
            {
                MessageBox.Show("生产时间格式不正确，应为 'yyyy年MM月dd日' 或 'yyyy年M月d日'。");
                return;
            }

            // 尝试解析当前时间，格式应为 "yyyy年MM月dd日" 或 "yyyy年M月d日"
            if (!DateTime.TryParseExact(currentTime, "yyyy年MM月dd日", System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out currentTimeParsed) &&
                !DateTime.TryParseExact(currentTime, "yyyy年M月d日", System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out currentTimeParsed))
            {
                MessageBox.Show("当前时间格式不正确，应为 'yyyy年MM月dd日' 或 'yyyy年M月d日'。");
                return;
            }

            string sql = "UPDATE DrugDateInfomation SET drug_name=@drug_name, shelf_life_months=@shelf_life_months, production_time=@production_time, currenttime=@current_time WHERE id=@id";

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@drug_name", drugName);
                    cmd.Parameters.AddWithValue("@shelf_life_months", shelfLifeMonths);
                    cmd.Parameters.AddWithValue("@production_time", productionTimeParsed.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@current_time", currentTimeParsed.ToString("yyyy-MM-dd HH:mm:ss"));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("修改成功！");
                        this.Close(); // 关闭更新窗体
                    }
                    else
                    {
                        MessageBox.Show("修改失败，没有数据被更新。");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("修改失败：" + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void txtDName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void datDPTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
