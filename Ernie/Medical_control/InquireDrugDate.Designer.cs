
namespace Pharmacy_Management_System
{
    partial class InquireDrugDate
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
            label2 = new Label();
            txtDName = new TextBox();
            groupBox1 = new GroupBox();
            btnOk = new Button();
            dgvDDate = new DataGridView();
            btnClear = new Button();
            btnClose = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDDate).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 61);
            label2.Name = "label2";
            label2.Size = new Size(98, 18);
            label2.TabIndex = 18;
            label2.Text = "药品名称：";
            // 
            // txtDName
            // 
            txtDName.Location = new Point(135, 53);
            txtDName.Margin = new Padding(3, 4, 3, 4);
            txtDName.Name = "txtDName";
            txtDName.Size = new Size(355, 31);
            txtDName.TabIndex = 19;
            txtDName.TextChanged += txtDName_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDName);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(14, 35);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(525, 111);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "保质期信息";
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.SkyBlue;
            btnOk.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.Location = new Point(52, 153);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 48);
            btnOk.TabIndex = 5;
            btnOk.Text = "确认";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // dgvDDate
            // 
            dgvDDate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDDate.Location = new Point(14, 223);
            dgvDDate.Margin = new Padding(3, 4, 3, 4);
            dgvDDate.Name = "dgvDDate";
            dgvDDate.RowHeadersWidth = 51;
            dgvDDate.RowTemplate.Height = 27;
            dgvDDate.Size = new Size(525, 447);
            dgvDDate.TabIndex = 6;
            dgvDDate.CellContentClick += dgvDDate_CellContentClick;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SkyBlue;
            btnClear.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(215, 153);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 48);
            btnClear.TabIndex = 13;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.SkyBlue;
            btnClose.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(380, 153);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 48);
            btnClose.TabIndex = 14;
            btnClose.Text = "取消";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // InquireDrugDate
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(552, 685);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(dgvDDate);
            Controls.Add(btnOk);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InquireDrugDate";
            Text = "查询药品保质期";
            Load += InquireDrugDate_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDDate).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgvDDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}