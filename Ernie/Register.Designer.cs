namespace Ernie
{
    partial class Register
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
            uiButton2 = new Sunny.UI.UIButton();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            uiLabel4 = new Sunny.UI.UILabel();
            uiButton1 = new Sunny.UI.UIButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(344, 535);
            uiButton2.Margin = new Padding(2, 3, 2, 3);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(169, 44);
            uiButton2.TabIndex = 23;
            uiButton2.Text = "注册";
            uiButton2.Click += btnRegister_Click;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(235, 421);
            uiLabel3.Margin = new Padding(2, 0, 2, 0);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(81, 30);
            uiLabel3.TabIndex = 17;
            uiLabel3.Text = "密码";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(235, 375);
            uiLabel2.Margin = new Padding(2, 0, 2, 0);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(55, 31);
            uiLabel2.TabIndex = 16;
            uiLabel2.Text = "账号";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
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
            uiLabel1.TabIndex = 15;
            uiLabel1.Text = "注册";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.TabIndex = 14;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.doge_dancing_like_a_king;
            pictureBox1.Location = new Point(2, 105);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1035, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(344, 383);
            txtUsername.Margin = new Padding(2, 3, 2, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(384, 23);
            txtUsername.TabIndex = 26;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(344, 421);
            txtPassword.Margin = new Padding(2, 3, 2, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(384, 23);
            txtPassword.TabIndex = 27;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(344, 464);
            txtConfirmPassword.Margin = new Padding(2, 3, 2, 3);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(384, 23);
            txtConfirmPassword.TabIndex = 29;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(196, 457);
            uiLabel4.Margin = new Padding(2, 0, 2, 0);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(138, 31);
            uiLabel4.TabIndex = 28;
            uiLabel4.Text = "再次输入密码";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(559, 535);
            uiButton1.Margin = new Padding(2, 3, 2, 3);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(169, 44);
            uiButton1.TabIndex = 30;
            uiButton1.Text = "返回登录";
            uiButton1.Click += btnBack_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1039, 681);
            Controls.Add(uiButton1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(uiLabel4);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(uiButton2);
            Controls.Add(uiLabel3);
            Controls.Add(uiLabel2);
            Controls.Add(uiLabel1);
            Controls.Add(panel1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Register";
            Text = "Form2";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Sunny.UI.UIRadioButton uiRadioButton2;
        private Sunny.UI.UIRadioButton uiRadioButton1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton uiButton1;
    }
}