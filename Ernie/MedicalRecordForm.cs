using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // 引入 MySQL 数据库的命名空间

namespace Ernie
{
    public partial class MedicalRecordForm : Form
    {
        public MedicalRecordForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            uiButton1.Click += new EventHandler(uiButton1_Click); // 绑定按钮点击事件
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string patientName = textBox1.Text;
            string age = textBox2.Text;
            string recordNumber = textBox3.Text;
            string prescriptionInfo = textBox4.Text;
            string department = uiComboBox1.Text;
            string doctorName = uiComboBox2.Text;
            string prescriptionTime = GetSelectedRadioButtonText(uiGroupBox2);

            string connectionString = "server=localhost;user=root;password=root;database=patient_information";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO medical_information (patient_name, age, record_number, prescription_info, department, doctor_name, prescription_time) VALUES (@patientName, @age, @recordNumber, @prescriptionInfo, @department, @doctorName, @prescriptionTime)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@patientName", patientName);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@recordNumber", recordNumber);
                        cmd.Parameters.AddWithValue("@prescriptionInfo", prescriptionInfo);
                        cmd.Parameters.AddWithValue("@department", department);
                        cmd.Parameters.AddWithValue("@doctorName", doctorName);
                        cmd.Parameters.AddWithValue("@prescriptionTime", prescriptionTime);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("病历信息已成功录入！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("录入失败: " + ex.Message);
                }
            }
        }

        private string GetSelectedRadioButtonText(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return string.Empty;
        }
    }
}
