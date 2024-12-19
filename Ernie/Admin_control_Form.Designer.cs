namespace Ernie
{
    partial class Admin_control_Form
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
            txtPassword = new TextBox();
            dataGridView3 = new DataGridView();
            button_delete = new Button();
            button_add = new Button();
            button_update = new Button();
            label_name = new Label();
            label_title = new Label();
            cmbRole = new ComboBox();
            label_hospital = new Label();
            txtUsername = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(226, 75);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(121, 27);
            txtPassword.TabIndex = 33;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(-3, 125);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(1128, 309);
            dataGridView3.TabIndex = 31;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(509, 67);
            button_delete.Margin = new Padding(4);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(96, 35);
            button_delete.TabIndex = 29;
            button_delete.Text = "删除";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += btnDeleteUser_Click;
            // 
            // button_add
            // 
            button_add.Location = new Point(509, 22);
            button_add.Margin = new Padding(4);
            button_add.Name = "button_add";
            button_add.Size = new Size(96, 37);
            button_add.TabIndex = 27;
            button_add.Text = "增加";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += btnAddUser_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(509, 113);
            button_update.Margin = new Padding(4);
            button_update.Name = "button_update";
            button_update.Size = new Size(96, 38);
            button_update.TabIndex = 28;
            button_update.Text = "修改";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += btnUpdateUser_Click;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.BackColor = SystemColors.Info;
            label_name.Location = new Point(152, 35);
            label_name.Margin = new Padding(4, 0, 4, 0);
            label_name.Name = "label_name";
            label_name.Size = new Size(54, 20);
            label_name.TabIndex = 20;
            label_name.Text = "用户名";
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.BackColor = SystemColors.Info;
            label_title.Location = new Point(152, 82);
            label_title.Margin = new Padding(4, 0, 4, 0);
            label_title.Name = "label_title";
            label_title.Size = new Size(39, 20);
            label_title.TabIndex = 34;
            label_title.Text = "密码";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "user", "admin" });
            cmbRole.Location = new Point(226, 113);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(151, 28);
            cmbRole.TabIndex = 29;
            // 
            // label_hospital
            // 
            label_hospital.AutoSize = true;
            label_hospital.BackColor = SystemColors.Info;
            label_hospital.Location = new Point(152, 116);
            label_hospital.Margin = new Padding(4, 0, 4, 0);
            label_hospital.Name = "label_hospital";
            label_hospital.Size = new Size(39, 20);
            label_hospital.TabIndex = 23;
            label_hospital.Text = "角色";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(226, 32);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(121, 27);
            txtUsername.TabIndex = 32;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Info;
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(button_delete);
            panel3.Controls.Add(cmbRole);
            panel3.Controls.Add(label_title);
            panel3.Controls.Add(button_add);
            panel3.Controls.Add(button_update);
            panel3.Controls.Add(label_hospital);
            panel3.Controls.Add(label_name);
            panel3.Location = new Point(-3, 431);
            panel3.Name = "panel3";
            panel3.Size = new Size(1128, 194);
            panel3.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1128, 127);
            panel2.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("隶书", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(454, 42);
            label6.Name = "label6";
            label6.Size = new Size(289, 44);
            label6.TabIndex = 1;
            label6.Text = "信息管理后台";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.health_美图抠图20241212;
            pictureBox1.Location = new Point(266, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Admin_control_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 621);
            Controls.Add(panel2);
            Controls.Add(dataGridView3);
            Controls.Add(panel3);
            Name = "Admin_control_Form";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtPassword;
        private DataGridView dataGridView3;
        private Button button_delete;
        private Button button_add;
        private Button button_update;
        private Label label_name;
        private Label label_title;
        private ComboBox cmbRole;
        private Label label_hospital;
        private TextBox txtUsername;
        private Panel panel3;
        private Panel panel2;
        private Label label6;
        private PictureBox pictureBox1;
    }
}