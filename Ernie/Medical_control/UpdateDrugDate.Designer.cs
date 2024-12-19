
namespace Pharmacy_Management_System.药品保质期信息
{
    partial class UpdateDrugDate
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
            groupBox1 = new GroupBox();
            txtDNumber = new TextBox();
            label1 = new Label();
            datDCTime = new DateTimePicker();
            label4 = new Label();
            datDPTime = new DateTimePicker();
            label5 = new Label();
            txtDDate = new TextBox();
            label3 = new Label();
            txtDName = new TextBox();
            label2 = new Label();
            btnOk = new Button();
            btnClose = new Button();
            btnClear = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDNumber);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(datDCTime);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(datDPTime);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDDate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDName);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Bernard MT Condensed", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(411, 421);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "保质期信息";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtDNumber
            // 
            txtDNumber.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDNumber.Location = new Point(135, 47);
            txtDNumber.Margin = new Padding(3, 4, 3, 4);
            txtDNumber.Name = "txtDNumber";
            txtDNumber.Size = new Size(241, 28);
            txtDNumber.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 51);
            label1.Name = "label1";
            label1.Size = new Size(62, 18);
            label1.TabIndex = 28;
            label1.Text = "序号：";
            // 
            // datDCTime
            // 
            datDCTime.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            datDCTime.Location = new Point(135, 341);
            datDCTime.Margin = new Padding(3, 4, 3, 4);
            datDCTime.Name = "datDCTime";
            datDCTime.Size = new Size(241, 28);
            datDCTime.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 351);
            label4.Name = "label4";
            label4.Size = new Size(89, 18);
            label4.TabIndex = 26;
            label4.Text = "当前时间:";
            // 
            // datDPTime
            // 
            datDPTime.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            datDPTime.Location = new Point(135, 264);
            datDPTime.Margin = new Padding(3, 4, 3, 4);
            datDPTime.Name = "datDPTime";
            datDPTime.Size = new Size(241, 28);
            datDPTime.TabIndex = 25;
            datDPTime.ValueChanged += datDPTime_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 273);
            label5.Name = "label5";
            label5.Size = new Size(98, 18);
            label5.TabIndex = 24;
            label5.Text = "生产时间：";
            // 
            // txtDDate
            // 
            txtDDate.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDDate.Location = new Point(135, 193);
            txtDDate.Margin = new Padding(3, 4, 3, 4);
            txtDDate.Name = "txtDDate";
            txtDDate.Size = new Size(241, 28);
            txtDDate.TabIndex = 21;
            txtDDate.TextChanged += txtDDate_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 197);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 20;
            label3.Text = "保质期（月）：";
            // 
            // txtDName
            // 
            txtDName.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDName.Location = new Point(135, 116);
            txtDName.Margin = new Padding(3, 4, 3, 4);
            txtDName.Name = "txtDName";
            txtDName.Size = new Size(241, 28);
            txtDName.TabIndex = 19;
            txtDName.TextChanged += txtDName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 120);
            label2.Name = "label2";
            label2.Size = new Size(98, 18);
            label2.TabIndex = 18;
            label2.Text = "药品名称：";
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.SkyBlue;
            btnOk.Location = new Point(39, 445);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(87, 51);
            btnOk.TabIndex = 5;
            btnOk.Text = "确认";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.SkyBlue;
            btnClose.Location = new Point(317, 447);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(84, 49);
            btnClose.TabIndex = 6;
            btnClose.Text = "取消";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SkyBlue;
            btnClear.Location = new Point(173, 447);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 49);
            btnClear.TabIndex = 7;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // UpdateDrugDate
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(440, 519);
            Controls.Add(btnClear);
            Controls.Add(btnClose);
            Controls.Add(btnOk);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UpdateDrugDate";
            Text = "修改药品保质期";
            Load += UpdateDrugDate_Load;
            Click += UpdateDrugDate_Click;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datDCTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datDPTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNumber;
    }
}