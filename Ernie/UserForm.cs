using Pharmacy_Management_System;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Ernie
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            timer_time.Start();
            // 显示home面板

        }

        private void button_preview(object sender, EventArgs e)
        {
            Online_docotor_search frm = new Online_docotor_search();
            frm.Show();
        }

        private void button_chat(object sender, EventArgs e)
        {
            AI_cahtbot frm = new AI_cahtbot();
            frm.Show();
        }

        private void button_medical(object sender, EventArgs e)
        {
            DrugDateinfomation frm = new DrugDateinfomation();
            frm.Show();
        }

        private void button_exit(object sender, EventArgs e)
        {
            Login frm_sign = new Login();
            frm_sign.Show();
            this.Close();
            this.Dispose();
        }
        private void timer_time_Tick(object sender, EventArgs e)
        {
            DateTime nowTime = System.DateTime.Now.ToLocalTime();
            label_time.Text = nowTime.ToString("HH:mm:ss"); // 更新时间显示
        }
    }
    
}
