namespace Ernie
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            uiButton1 = new Sunny.UI.UIButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            home = new Sunny.UI.UIButton();
            uiButton2 = new Sunny.UI.UIButton();
            uiButton11 = new Sunny.UI.UIButton();
            uiButton10 = new Sunny.UI.UIButton();
            uiButton9 = new Sunny.UI.UIButton();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            uiLabel1 = new Sunny.UI.UILabel();
            panel2 = new Panel();
            label_time = new Label();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            dang = new Sunny.UI.UILabel();
            timer_time = new System.Windows.Forms.Timer(components);
            panelHome = new Panel();
            panelVisual = new Panel();
            panelAdminControl = new Panel();
            WebViewa = new Microsoft.Web.WebView2.WinForms.WebView2();
            pictureBox3 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panelHome.SuspendLayout();
            panelVisual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WebViewa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(4, 394);
            uiButton1.Margin = new Padding(4);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(180, 122);
            uiButton1.TabIndex = 0;
            uiButton1.Text = "全国医院信息管理";
            uiButton1.Click += button_preview_control;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(home);
            flowLayoutPanel1.Controls.Add(uiButton2);
            flowLayoutPanel1.Controls.Add(uiButton11);
            flowLayoutPanel1.Controls.Add(uiButton1);
            flowLayoutPanel1.Controls.Add(uiButton10);
            flowLayoutPanel1.Controls.Add(uiButton9);
            flowLayoutPanel1.Location = new Point(3, 54);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(184, 748);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // home
            // 
            home.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            home.Location = new Point(4, 4);
            home.Margin = new Padding(4);
            home.MinimumSize = new Size(1, 1);
            home.Name = "home";
            home.Size = new Size(180, 122);
            home.TabIndex = 12;
            home.Text = "Home";
            home.Click += button_home;
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(4, 134);
            uiButton2.Margin = new Padding(4);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(180, 122);
            uiButton2.TabIndex = 10;
            uiButton2.Text = "医院数据可视化";
            uiButton2.Click += button_viual;
            // 
            // uiButton11
            // 
            uiButton11.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton11.Location = new Point(4, 264);
            uiButton11.Margin = new Padding(4);
            uiButton11.MinimumSize = new Size(1, 1);
            uiButton11.Name = "uiButton11";
            uiButton11.Size = new Size(180, 122);
            uiButton11.TabIndex = 11;
            uiButton11.Text = " 医生信息管理";
            uiButton11.Click += button_information_control;
            // 
            // uiButton10
            // 
            uiButton10.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton10.Location = new Point(4, 524);
            uiButton10.Margin = new Padding(4);
            uiButton10.MinimumSize = new Size(1, 1);
            uiButton10.Name = "uiButton10";
            uiButton10.Size = new Size(180, 122);
            uiButton10.TabIndex = 10;
            uiButton10.Text = "处方管理";
            uiButton10.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton10.Click += button_medical_control;
            // 
            // uiButton9
            // 
            uiButton9.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton9.Location = new Point(4, 654);
            uiButton9.Margin = new Padding(4);
            uiButton9.MinimumSize = new Size(1, 1);
            uiButton9.Name = "uiButton9";
            uiButton9.Size = new Size(180, 122);
            uiButton9.TabIndex = 9;
            uiButton9.Text = "管理员后台";
            uiButton9.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton9.Click += button_admin_control;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(uiLabel1);
            panel1.Location = new Point(1, -2);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1341, 64);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.health_美图抠图20241212;
            pictureBox2.Location = new Point(0, 5);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(129, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.R_C;
            pictureBox1.Location = new Point(368, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("隶书", 18F, FontStyle.Bold, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(442, -4);
            uiLabel1.Margin = new Padding(4, 0, 4, 0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(527, 67);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "医疗助手对话系统管理员后台";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label_time);
            panel2.Controls.Add(uiLabel4);
            panel2.Controls.Add(uiLabel2);
            panel2.Controls.Add(dang);
            panel2.Location = new Point(177, 740);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1165, 62);
            panel2.TabIndex = 3;
            // 
            // label_time
            // 
            label_time.AutoSize = true;
            label_time.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_time.Location = new Point(914, 27);
            label_time.Margin = new Padding(4, 0, 4, 0);
            label_time.Name = "label_time";
            label_time.Size = new Size(89, 19);
            label_time.TabIndex = 4;
            label_time.Text = "HH:MM:SS";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(1023, 24);
            uiLabel4.Margin = new Padding(4, 0, 4, 0);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(99, 27);
            uiLabel4.TabIndex = 3;
            uiLabel4.Text = "退出登录";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            uiLabel4.Click += label_logOut_Click;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(157, 24);
            uiLabel2.Margin = new Padding(4, 0, 4, 0);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(188, 27);
            uiLabel2.TabIndex = 1;
            uiLabel2.Text = "root（管理员）";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dang
            // 
            dang.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dang.ForeColor = Color.FromArgb(48, 48, 48);
            dang.Location = new Point(55, 24);
            dang.Margin = new Padding(4, 0, 4, 0);
            dang.Name = "dang";
            dang.Size = new Size(129, 27);
            dang.TabIndex = 0;
            dang.Text = "当前用户:";
            dang.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer_time
            // 
            timer_time.Tick += timer_time_Tick;
            // 
            // panelHome
            // 
            panelHome.BackColor = SystemColors.InfoText;
            panelHome.Controls.Add(panelVisual);
            panelHome.Controls.Add(pictureBox3);
            panelHome.Location = new Point(181, 65);
            panelHome.Margin = new Padding(4);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1161, 675);
            panelHome.TabIndex = 4;
            panelHome.Visible = false;
            // 
            // panelVisual
            // 
            panelVisual.BackColor = SystemColors.HighlightText;
            panelVisual.Controls.Add(panelAdminControl);
            panelVisual.Controls.Add(WebViewa);
            panelVisual.Location = new Point(4, 0);
            panelVisual.Margin = new Padding(4);
            panelVisual.Name = "panelVisual";
            panelVisual.Size = new Size(1140, 675);
            panelVisual.TabIndex = 1;
            panelVisual.Visible = false;
            // 
            // panelAdminControl
            // 
            panelAdminControl.Location = new Point(24, 4);
            panelAdminControl.Name = "panelAdminControl";
            panelAdminControl.Size = new Size(1113, 652);
            panelAdminControl.TabIndex = 1;
            panelAdminControl.Visible = false;
            // 
            // WebViewa
            // 
            WebViewa.AllowExternalDrop = true;
            WebViewa.CreationProperties = null;
            WebViewa.DefaultBackgroundColor = Color.White;
            WebViewa.Location = new Point(4, 4);
            WebViewa.Margin = new Padding(4);
            WebViewa.Name = "WebViewa";
            WebViewa.Size = new Size(1136, 671);
            WebViewa.TabIndex = 0;
            WebViewa.Visible = false;
            WebViewa.ZoomFactor = 1D;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.心电;
            pictureBox3.Location = new Point(85, 87);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(995, 488);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1336, 801);
            Controls.Add(panelHome);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(4);
            Name = "AdminForm";
            Text = "AdminForm";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelHome.ResumeLayout(false);
            panelVisual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)WebViewa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIButton uiButton1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Sunny.UI.UIButton uiButton10;
        private Sunny.UI.UIButton uiButton9;
        private Sunny.UI.UIButton uiButton11;
        private Sunny.UI.UIButton uiButton2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel dang;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel2;
        private System.Windows.Forms.Timer timer_time;
        private Label label_time;
        private Sunny.UI.UIButton home;
        private Panel panelHome;
        private PictureBox pictureBox3;
        private Panel panelVisual;
        private Microsoft.Web.WebView2.WinForms.WebView2 WebViewa;
        private Panel panelAdminControl;
    }
}