namespace Ernie
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiMillisecondTimer1 = new Sunny.UI.UIMillisecondTimer(components);
            uiButton1 = new Sunny.UI.UIButton();
            uiRadioButton1 = new Sunny.UI.UIRadioButton();
            uiRadioButton2 = new Sunny.UI.UIRadioButton();
            uiButton2 = new Sunny.UI.UIButton();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.doge_dancing_like_a_king;
            pictureBox1.Location = new Point(2, 103);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1035, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1039, 235);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.health_美图抠图20241212;
            pictureBox2.Location = new Point(2, 0);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1035, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // uiLabel1
            // 
            uiLabel1.Dock = DockStyle.Top;
            uiLabel1.Font = new Font("隶书", 36F, FontStyle.Bold, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(0, 235);
            uiLabel1.Margin = new Padding(2, 0, 2, 0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(1039, 114);
            uiLabel1.TabIndex = 2;
            uiLabel1.Text = "医疗助手对话系统";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(292, 376);
            uiLabel2.Margin = new Padding(2, 0, 2, 0);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(55, 31);
            uiLabel2.TabIndex = 3;
            uiLabel2.Text = "账号";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(292, 416);
            uiLabel3.Margin = new Padding(2, 0, 2, 0);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(63, 31);
            uiLabel3.TabIndex = 4;
            uiLabel3.Text = "密码";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(352, 545);
            uiButton1.Margin = new Padding(2, 3, 2, 3);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(138, 42);
            uiButton1.TabIndex = 7;
            uiButton1.Text = "登录";
            uiButton1.Click += btnLogin_Click;
            // 
            // uiRadioButton1
            // 
            uiRadioButton1.Checked = true;
            uiRadioButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiRadioButton1.Location = new Point(421, 476);
            uiRadioButton1.Margin = new Padding(2, 3, 2, 3);
            uiRadioButton1.MinimumSize = new Size(1, 1);
            uiRadioButton1.Name = "uiRadioButton1";
            uiRadioButton1.Size = new Size(79, 31);
            uiRadioButton1.TabIndex = 11;
            uiRadioButton1.Text = "用户";
            uiRadioButton1.Click += residuebutton_Click_user;
            // 
            // uiRadioButton2
            // 
            uiRadioButton2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiRadioButton2.Location = new Point(552, 476);
            uiRadioButton2.Margin = new Padding(2, 3, 2, 3);
            uiRadioButton2.MinimumSize = new Size(1, 1);
            uiRadioButton2.Name = "uiRadioButton2";
            uiRadioButton2.Size = new Size(93, 31);
            uiRadioButton2.TabIndex = 12;
            uiRadioButton2.Text = "管理员";
            uiRadioButton2.Click += residuebutton_Click_admin;
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(618, 545);
            uiButton2.Margin = new Padding(2, 3, 2, 3);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(121, 42);
            uiButton2.TabIndex = 13;
            uiButton2.Text = "注册";
            uiButton2.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Click += btnRegister_Click;
            uiButton2.DpiChangedAfterParent += btnRegister_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(352, 376);
            txtUsername.Margin = new Padding(2, 3, 2, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(387, 23);
            txtUsername.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(352, 422);
            txtPassword.Margin = new Padding(2, 3, 2, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(387, 23);
            txtPassword.TabIndex = 15;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1039, 681);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(uiButton2);
            Controls.Add(uiRadioButton2);
            Controls.Add(uiRadioButton1);
            Controls.Add(uiButton1);
            Controls.Add(uiLabel3);
            Controls.Add(uiLabel2);
            Controls.Add(uiLabel1);
            Controls.Add(panel1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Login";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIMillisecondTimer uiMillisecondTimer1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIRadioButton uiRadioButton1;
        private Sunny.UI.UIRadioButton uiRadioButton2;
        private Sunny.UI.UIButton uiButton2;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}