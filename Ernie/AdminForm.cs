using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using Sunny.UI;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;

namespace Ernie
{
    public partial class AdminForm : Form
    {
        private Panel panelPreviewControl;
        private Panel panelMedicalControl;

        private WebView2 webViewa;
        private DoctorInfoForm doctorInfoForm;
        private MedicalRecordForm medicalRecordFor;

        public AdminForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            timer_time.Start();

            // 初始化面板
            InitializePanels();
            InitializeWebView();
            InitializeDoctorInfoForm();

            // 显示home面板
            ShowPanel(panelHome);


        }

        private void InitializePanels()
        {
            panelPreviewControl = new Panel { Visible = false };
            panelMedicalControl = new Panel { Visible = false };

            // 将面板添加到表单中
            this.Controls.Add(panelPreviewControl);
            this.Controls.Add(panelMedicalControl);

        }

        private void InitializeDoctorInfoForm()
        {
            doctorInfoForm = new DoctorInfoForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            doctorInfoForm.Show();
        }

        private void ShowPanel(Panel panelToShow)
        {
            // 隐藏所有面板
            panelHome.Visible = false;
            panelVisual.Visible = false;
            panelPreviewControl.Visible = false;
            panelMedicalControl.Visible = false;
            panelAdminControl.Visible = false;

            // 显示指定的面板
            panelToShow.Visible = true;
        }

        private void button_home(object sender, EventArgs e)
        {
            ShowPanel(panelHome);
        }

        private void button_viual(object sender, EventArgs e)
        {
            ShowPanel(panelVisual);
        }

        private void button_information_control(object sender, EventArgs e)
        {
            // 创建并显示DoctorInfoForm窗体
            DoctorInfoForm frm = new DoctorInfoForm();
            frm.Show();
        }

        private void button_preview_control(object sender, EventArgs e)
        {
            Hospital_sum frm = new Hospital_sum();
            frm.Show();
        }

        private void button_medical_control(object sender, EventArgs e)
        {
            MedicalRecordForm frm = new MedicalRecordForm();
            frm.Show();
        }

        private void button_admin_control(object sender, EventArgs e)
        {

            Admin_control_Form frm = new Admin_control_Form();
            frm.Show();

        }

        private void timer_time_Tick(object sender, EventArgs e)
        {
            DateTime nowTime = System.DateTime.Now.ToLocalTime();
            label_time.Text = nowTime.ToString("HH:mm:ss"); // 更新时间显示
        }

        private void label_logOut_Click(object sender, EventArgs e)
        {
            Login frm_sign = new Login();
            frm_sign.Show();
            this.Close();
            this.Dispose();
        }

        private async void InitializeWebView()
        {
            webViewa = new WebView2
            {
                Dock = DockStyle.Fill
            };

            // 将 WebView2 控件添加到表单中
            this.Controls.Add(webViewa);

            // 初始化 WebView2
            await webViewa.EnsureCoreWebView2Async();

            // 加载ECharts的HTML内容
            string htmlContent = @"
<!DOCTYPE html>
<html>
<head>
    <meta charset='utf-8'>
    <script src='https://cdn.jsdelivr.net/npm/echarts/dist/echarts.min.js'></script>
    <style>
        body, html {
            margin: 0;
            padding: 0;
            width: 100%;
            height: 100%;
            display: flex;
            justify-content: flex-start; /* 调整为左对齐 */
            align-items: center; /* 垂直居中 */
        }
        .chart-container {
            display: flex;
            flex-direction: column;
            width: 80%; /* 调整宽度 */
            height: 80%; /* 调整高度 */
            margin-left: 10%; /* 向右移动 */
        }
        .chart {
            width: 100%; /* 调整宽度 */
            height: 50%; /* 调整高度 */
        }
    </style>
</head>
<body>
    <div class='chart-container'>
        <div id='chart1' class='chart'></div>
        <div id='chart3' class='chart'></div>
    </div>
    <script type='text/javascript'>
        var chart1 = echarts.init(document.getElementById('chart1'));
        var option1 = {
            title: { text: '嗷嗷科室数量可视化' },
            tooltip: {},
            legend: { data:['不同科室医生数量'] },
            xAxis: { data: ['皮肤科','心内科','妇科','普外科','骨科','小儿心外科'] },
            yAxis: {},
            series: [{ name: '数量', type: 'bar', data: [41, 24, 24, 21, 20, 1] }]
        };
        chart1.setOption(option1);

        var chart3 = echarts.init(document.getElementById('chart3'));
        var option3 = {
            title: { text: '嗷嗷在线问诊医生评分' },
            tooltip: { trigger: 'item' },
            legend: { top: '5%', left: 'center' },
            series: [
                {
                    name: '医生评分占比',
                    type: 'pie',
                    radius: ['40%', '70%'],
                    avoidLabelOverlap: false,
                    itemStyle: { borderRadius: 10, borderColor: '#fff', borderWidth: 2 },
                    label: { show: false, position: 'center' },
                    emphasis: { label: { show: true, fontSize: '40', fontWeight: 'bold' } },
                    labelLine: { show: false },
                    data: [
                        { value: 1048, name: '9-10评分' },
                        { value: 735, name: '8-9评分' },
                        { value: 580, name: '7-8评分' },
                        { value: 484, name: '5-6评分' },
                        { value: 300, name: '5分以下' }
                    ]
                }
            ]
        };
        chart3.setOption(option3);
    </script>
</body>
</html>";

            webViewa.NavigateToString(htmlContent);
        }
    }
}
