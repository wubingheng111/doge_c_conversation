namespace Ernie
{
    partial class UserForm
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
            pictureBox3 = new PictureBox();
            panelHome = new Panel();
            timer_time = new System.Windows.Forms.Timer(components);
            label_time = new Label();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            dang = new Sunny.UI.UILabel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            uiLabel1 = new Sunny.UI.UILabel();
            panel1 = new Panel();
            home = new Sunny.UI.UIButton();
            uiButton11 = new Sunny.UI.UIButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            uiButton1 = new Sunny.UI.UIButton();
            uiButton2 = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelHome.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            // panelHome
            // 
            panelHome.BackColor = SystemColors.InfoText;
            panelHome.Controls.Add(pictureBox3);
            panelHome.Location = new Point(178, 65);
            panelHome.Margin = new Padding(4);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1161, 675);
            panelHome.TabIndex = 8;
            // 
            // timer_time
            // 
            timer_time.Tick += timer_time_Tick;
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
            uiLabel4.Click += button_exit;
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
            uiLabel2.Text = "user（用户）";
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label_time);
            panel2.Controls.Add(uiLabel4);
            panel2.Controls.Add(uiLabel2);
            panel2.Controls.Add(dang);
            panel2.Location = new Point(174, 740);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1165, 62);
            panel2.TabIndex = 7;
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
            uiLabel1.Text = "医疗助手对话系统用户后台";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(uiLabel1);
            panel1.Location = new Point(-2, -2);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1341, 64);
            panel1.TabIndex = 6;
            // 
            // home
            // 
            home.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            home.Location = new Point(4, 4);
            home.Margin = new Padding(4);
            home.MinimumSize = new Size(1, 1);
            home.Name = "home";
            home.Size = new Size(166, 173);
            home.TabIndex = 12;
            home.Text = "Home";
            // 
            // uiButton11
            // 
            uiButton11.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton11.Location = new Point(4, 185);
            uiButton11.Margin = new Padding(4);
            uiButton11.MinimumSize = new Size(1, 1);
            uiButton11.Name = "uiButton11";
            uiButton11.Size = new Size(166, 185);
            uiButton11.TabIndex = 11;
            uiButton11.Text = "在线问诊医生查询";
            uiButton11.Click += button_preview;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(home);
            flowLayoutPanel1.Controls.Add(uiButton11);
            flowLayoutPanel1.Controls.Add(uiButton1);
            flowLayoutPanel1.Controls.Add(uiButton2);
            flowLayoutPanel1.Location = new Point(0, 54);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(184, 748);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(4, 378);
            uiButton1.Margin = new Padding(4);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(166, 202);
            uiButton1.TabIndex = 13;
            uiButton1.Text = "医疗对话小助手";
            uiButton1.Click += button_chat;
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(4, 588);
            uiButton2.Margin = new Padding(4);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(166, 215);
            uiButton2.TabIndex = 14;
            uiButton2.Text = "药品保质期录入系统";
            uiButton2.Click += button_medical;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 801);
            Controls.Add(panelHome);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(4);
            Name = "UserForm";
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelHome.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox3;
        private Panel panelHome;
        private System.Windows.Forms.Timer timer_time;
        private Label label_time;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel dang;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Sunny.UI.UILabel uiLabel1;
        private Panel panel1;
        private Sunny.UI.UIButton home;
        private Sunny.UI.UIButton uiButton11;
        private FlowLayoutPanel flowLayoutPanel1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
    }
}