namespace Ernie
{
    partial class Hospital_sum
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
            dataGridView4 = new DataGridView();
            txtName = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            panel2 = new Panel();
            txtDepartment = new TextBox();
            label_department = new Label();
            label_hospital = new Label();
            txtHospital = new TextBox();
            txtSpecialty = new TextBox();
            label_specialty = new Label();
            button_add = new Button();
            button_update = new Button();
            button_delete = new Button();
            button_search = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(1, 116);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 29;
            dataGridView4.Size = new Size(1118, 306);
            dataGridView4.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(216, 439);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(127, 27);
            txtName.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-3, 417);
            panel1.Name = "panel1";
            panel1.Size = new Size(1119, 197);
            panel1.TabIndex = 33;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("隶书", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(454, 42);
            label6.Name = "label6";
            label6.Size = new Size(379, 44);
            label6.TabIndex = 1;
            label6.Text = "全国医院信息管理";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-3, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1122, 109);
            panel2.TabIndex = 34;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(442, 441);
            txtDepartment.Margin = new Padding(4);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(127, 27);
            txtDepartment.TabIndex = 21;
            // 
            // label_department
            // 
            label_department.AutoSize = true;
            label_department.BackColor = SystemColors.Info;
            label_department.Location = new Point(375, 441);
            label_department.Margin = new Padding(4, 0, 4, 0);
            label_department.Name = "label_department";
            label_department.Size = new Size(69, 20);
            label_department.TabIndex = 24;
            label_department.Text = "重点科室";
            // 
            // label_hospital
            // 
            label_hospital.AutoSize = true;
            label_hospital.BackColor = SystemColors.Info;
            label_hospital.Location = new Point(375, 480);
            label_hospital.Margin = new Padding(4, 0, 4, 0);
            label_hospital.Name = "label_hospital";
            label_hospital.RightToLeft = RightToLeft.No;
            label_hospital.Size = new Size(69, 20);
            label_hospital.TabIndex = 25;
            label_hospital.Text = "医院等级";
            // 
            // txtHospital
            // 
            txtHospital.Location = new Point(439, 480);
            txtHospital.Margin = new Padding(4);
            txtHospital.Name = "txtHospital";
            txtHospital.Size = new Size(127, 27);
            txtHospital.TabIndex = 26;
            // 
            // txtSpecialty
            // 
            txtSpecialty.Location = new Point(216, 529);
            txtSpecialty.Margin = new Padding(4);
            txtSpecialty.Name = "txtSpecialty";
            txtSpecialty.Size = new Size(354, 27);
            txtSpecialty.TabIndex = 27;
            // 
            // label_specialty
            // 
            label_specialty.AutoSize = true;
            label_specialty.BackColor = SystemColors.Info;
            label_specialty.Location = new Point(149, 529);
            label_specialty.Margin = new Padding(4, 0, 4, 0);
            label_specialty.Name = "label_specialty";
            label_specialty.Size = new Size(69, 20);
            label_specialty.TabIndex = 28;
            label_specialty.Text = "联系电话";
            // 
            // button_add
            // 
            button_add.Location = new Point(658, 441);
            button_add.Margin = new Padding(4);
            button_add.Name = "button_add";
            button_add.Size = new Size(96, 39);
            button_add.TabIndex = 29;
            button_add.Text = "增加";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(762, 504);
            button_update.Margin = new Padding(4);
            button_update.Name = "button_update";
            button_update.Size = new Size(96, 45);
            button_update.TabIndex = 30;
            button_update.Text = "修改";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(658, 504);
            button_delete.Margin = new Padding(4);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(96, 45);
            button_delete.TabIndex = 31;
            button_delete.Text = "删除";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_search
            // 
            button_search.Location = new Point(762, 441);
            button_search.Margin = new Padding(4);
            button_search.Name = "button_search";
            button_search.Size = new Size(96, 39);
            button_search.TabIndex = 32;
            button_search.Text = "查询";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 63);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 27);
            textBox1.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Location = new Point(152, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 37;
            label1.Text = "医院地址";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Location = new Point(152, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 36;
            label2.Text = "医院名称";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(219, 24);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 27);
            textBox2.TabIndex = 35;
            // 
            // Hospital_sum
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 621);
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
            Controls.Add(txtDepartment);
            Controls.Add(panel1);
            Controls.Add(txtName);
            Controls.Add(dataGridView4);
            Name = "Hospital_sum";
            Text = "Hospital_sum";
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView4;
        private TextBox txtName;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Panel panel2;
        private TextBox txtDepartment;
        private Label label_department;
        private Label label_hospital;
        private TextBox txtHospital;
        private TextBox txtSpecialty;
        private Label label_specialty;
        private Button button_add;
        private Button button_update;
        private Button button_delete;
        private Button button_search;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}