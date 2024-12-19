namespace Ernie
{
    partial class DoctorInfoForm
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
            dataGridView1 = new DataGridView();
            txtName = new TextBox();
            txtTitle = new TextBox();
            txtDepartment = new TextBox();
            label_name = new Label();
            label_title = new Label();
            label_department = new Label();
            label_hospital = new Label();
            txtHospital = new TextBox();
            txtSpecialty = new TextBox();
            label_specialty = new Label();
            button_add = new Button();
            button_update = new Button();
            button_delete = new Button();
            button_search = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 113);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1119, 304);
            dataGridView1.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(223, 440);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(127, 27);
            txtName.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(223, 481);
            txtTitle.Margin = new Padding(4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(127, 27);
            txtTitle.TabIndex = 2;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(449, 442);
            txtDepartment.Margin = new Padding(4);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(127, 27);
            txtDepartment.TabIndex = 3;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.BackColor = SystemColors.Info;
            label_name.Location = new Point(138, 447);
            label_name.Margin = new Padding(4, 0, 4, 0);
            label_name.Name = "label_name";
            label_name.Size = new Size(69, 20);
            label_name.TabIndex = 4;
            label_name.Text = "医生姓名";
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.BackColor = SystemColors.Info;
            label_title.Location = new Point(156, 488);
            label_title.Margin = new Padding(4, 0, 4, 0);
            label_title.Name = "label_title";
            label_title.Size = new Size(39, 20);
            label_title.TabIndex = 5;
            label_title.Text = "职称";
            // 
            // label_department
            // 
            label_department.AutoSize = true;
            label_department.BackColor = SystemColors.Info;
            label_department.Location = new Point(382, 442);
            label_department.Margin = new Padding(4, 0, 4, 0);
            label_department.Name = "label_department";
            label_department.Size = new Size(39, 20);
            label_department.TabIndex = 6;
            label_department.Text = "科室";
            // 
            // label_hospital
            // 
            label_hospital.AutoSize = true;
            label_hospital.BackColor = SystemColors.Info;
            label_hospital.Location = new Point(382, 481);
            label_hospital.Margin = new Padding(4, 0, 4, 0);
            label_hospital.Name = "label_hospital";
            label_hospital.Size = new Size(39, 20);
            label_hospital.TabIndex = 7;
            label_hospital.Text = "医院";
            // 
            // txtHospital
            // 
            txtHospital.Location = new Point(446, 481);
            txtHospital.Margin = new Padding(4);
            txtHospital.Name = "txtHospital";
            txtHospital.Size = new Size(127, 27);
            txtHospital.TabIndex = 8;
            // 
            // txtSpecialty
            // 
            txtSpecialty.Location = new Point(223, 530);
            txtSpecialty.Margin = new Padding(4);
            txtSpecialty.Name = "txtSpecialty";
            txtSpecialty.Size = new Size(354, 27);
            txtSpecialty.TabIndex = 9;
            // 
            // label_specialty
            // 
            label_specialty.AutoSize = true;
            label_specialty.BackColor = SystemColors.Info;
            label_specialty.Location = new Point(156, 530);
            label_specialty.Margin = new Padding(4, 0, 4, 0);
            label_specialty.Name = "label_specialty";
            label_specialty.Size = new Size(39, 20);
            label_specialty.TabIndex = 10;
            label_specialty.Text = "擅长";
            // 
            // button_add
            // 
            button_add.Location = new Point(665, 442);
            button_add.Margin = new Padding(4);
            button_add.Name = "button_add";
            button_add.Size = new Size(96, 39);
            button_add.TabIndex = 11;
            button_add.Text = "增加";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += btnAdd_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(769, 505);
            button_update.Margin = new Padding(4);
            button_update.Name = "button_update";
            button_update.Size = new Size(96, 45);
            button_update.TabIndex = 13;
            button_update.Text = "修改";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += btnUpdate_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(665, 505);
            button_delete.Margin = new Padding(4);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(96, 45);
            button_delete.TabIndex = 14;
            button_delete.Text = "删除";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += btnDelete_Click;
            // 
            // button_search
            // 
            button_search.Location = new Point(769, 442);
            button_search.Margin = new Padding(4);
            button_search.Name = "button_search";
            button_search.Size = new Size(96, 39);
            button_search.TabIndex = 15;
            button_search.Text = "查询";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += btnSearch_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Location = new Point(4, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(1119, 197);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(4, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(1122, 109);
            panel2.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("隶书", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(454, 42);
            label6.Name = "label6";
            label6.Size = new Size(469, 44);
            label6.TabIndex = 1;
            label6.Text = "在线问诊医生信息录入";
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
            // DoctorInfoForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 614);
            Controls.Add(panel2);
            Controls.Add(button_search);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(button_add);
            Controls.Add(label_specialty);
            Controls.Add(txtSpecialty);
            Controls.Add(txtHospital);
            Controls.Add(label_hospital);
            Controls.Add(label_department);
            Controls.Add(label_title);
            Controls.Add(label_name);
            Controls.Add(txtDepartment);
            Controls.Add(txtTitle);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "DoctorInfoForm";
            Text = "DoctorInfoForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtName;
        private TextBox txtTitle;
        private TextBox txtDepartment;
        private Label label_name;
        private Label label_title;
        private Label label_department;
        private Label label_hospital;
        private TextBox txtHospital;
        private TextBox txtSpecialty;
        private Label label_specialty;
        private Button button_add;
        private Button button_update;
        private Button button_delete;
        private Button button_search;
        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private PictureBox pictureBox1;
    }
}