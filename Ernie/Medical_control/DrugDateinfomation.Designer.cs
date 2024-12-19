
namespace Pharmacy_Management_System
{
    partial class DrugDateinfomation
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
            dgvDDate = new DataGridView();
            groupBox1 = new GroupBox();
            txtDNumber = new TextBox();
            label6 = new Label();
            datDCTime = new DateTimePicker();
            label4 = new Label();
            datDPTime = new DateTimePicker();
            label5 = new Label();
            txtDDate = new TextBox();
            label3 = new Label();
            txtDName = new TextBox();
            label2 = new Label();
            btnExit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnInquire = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDDate).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvDDate
            // 
            dgvDDate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDDate.Location = new Point(425, 128);
            dgvDDate.Margin = new Padding(3, 4, 3, 4);
            dgvDDate.Name = "dgvDDate";
            dgvDDate.RowHeadersWidth = 51;
            dgvDDate.RowTemplate.Height = 27;
            dgvDDate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDDate.Size = new Size(623, 571);
            dgvDDate.TabIndex = 0;
            dgvDDate.CellContentClick += dataGridView1_CellContentClick;
            dgvDDate.Click += dgvDDate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDNumber);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(datDCTime);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(datDPTime);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDDate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDName);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Bernard MT Condensed", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(14, 128);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(405, 429);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "保质期信息";
            // 
            // txtDNumber
            // 
            txtDNumber.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDNumber.Location = new Point(130, 61);
            txtDNumber.Margin = new Padding(3, 4, 3, 4);
            txtDNumber.Name = "txtDNumber";
            txtDNumber.Size = new Size(241, 25);
            txtDNumber.TabIndex = 28;
            txtDNumber.TextChanged += txtDNumber_TextChanged;
            // 
            // label6
            // 
            label6.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(39, 65);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 0;
            label6.Text = "序号：";
            // 
            // datDCTime
            // 
            datDCTime.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            datDCTime.Location = new Point(130, 351);
            datDCTime.Margin = new Padding(3, 4, 3, 4);
            datDCTime.Name = "datDCTime";
            datDCTime.Size = new Size(241, 25);
            datDCTime.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 360);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 26;
            label4.Text = "当前时间：";
            // 
            // datDPTime
            // 
            datDPTime.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            datDPTime.Location = new Point(130, 280);
            datDPTime.Margin = new Padding(3, 4, 3, 4);
            datDPTime.Name = "datDPTime";
            datDPTime.Size = new Size(241, 25);
            datDPTime.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 280);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 24;
            label5.Text = "生产时间：";
            // 
            // txtDDate
            // 
            txtDDate.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDDate.Location = new Point(130, 209);
            txtDDate.Margin = new Padding(3, 4, 3, 4);
            txtDDate.Name = "txtDDate";
            txtDDate.Size = new Size(241, 25);
            txtDDate.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 213);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 20;
            label3.Text = "保质期（月）：";
            // 
            // txtDName
            // 
            txtDName.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDName.Location = new Point(130, 135);
            txtDName.Margin = new Padding(3, 4, 3, 4);
            txtDName.Name = "txtDName";
            txtDName.Size = new Size(241, 25);
            txtDName.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 139);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 18;
            label2.Text = "药品名称：";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SkyBlue;
            btnExit.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(259, 657);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 48);
            btnExit.TabIndex = 18;
            btnExit.Text = "退出";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SkyBlue;
            btnDelete.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(313, 579);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 48);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "删除";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SkyBlue;
            btnClear.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(88, 657);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 48);
            btnClear.TabIndex = 16;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SkyBlue;
            btnUpdate.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(170, 579);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 48);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "修改";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInquire
            // 
            btnInquire.BackColor = Color.SkyBlue;
            btnInquire.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnInquire.Location = new Point(32, 579);
            btnInquire.Margin = new Padding(3, 4, 3, 4);
            btnInquire.Name = "btnInquire";
            btnInquire.Size = new Size(94, 48);
            btnInquire.TabIndex = 19;
            btnInquire.Text = "查询";
            btnInquire.UseVisualStyleBackColor = false;
            btnInquire.Click += btnInquire_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(2, -6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1048, 127);
            panel2.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("隶书", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(454, 42);
            label1.Name = "label1";
            label1.Size = new Size(379, 44);
            label1.TabIndex = 1;
            label1.Text = "药品信息查询平台";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Ernie.Properties.Resources.health_美图抠图20241212;
            pictureBox1.Location = new Point(266, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DrugDateinfomation
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1062, 733);
            Controls.Add(panel2);
            Controls.Add(btnInquire);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(groupBox1);
            Controls.Add(dgvDDate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DrugDateinfomation";
            Text = "药品保质期信息";
            Load += DrugDateinfomation_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDDate).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datDCTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datDPTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInquire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDNumber;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}