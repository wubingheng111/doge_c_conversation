namespace Ernie
{
    partial class AI_cahtbot
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textShow = new Sunny.UI.UIRichTextBox();
            textSend = new Sunny.UI.UIRichTextBox();
            buttonSend = new Sunny.UI.UIButton();
            ClearHistory = new Sunny.UI.UISymbolButton();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            uiGroupBox2 = new Sunny.UI.UIGroupBox();
            textTotalTake = new Sunny.UI.UITextBox();
            uiLabel6 = new Sunny.UI.UILabel();
            textReturnTake = new Sunny.UI.UITextBox();
            uiLabel7 = new Sunny.UI.UILabel();
            textPromptTake = new Sunny.UI.UITextBox();
            uiLabel8 = new Sunny.UI.UILabel();
            textFinishFlag = new Sunny.UI.UITextBox();
            uiLabel4 = new Sunny.UI.UILabel();
            textClearHistory = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            textObject = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            textId = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiGroupBox3 = new Sunny.UI.UIGroupBox();
            uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            switchSearch = new Sunny.UI.UISwitch();
            trackBarRandom = new Sunny.UI.UITrackBar();
            uiLabel5 = new Sunny.UI.UILabel();
            uiLabel10 = new Sunny.UI.UILabel();
            uiGroupBox1.SuspendLayout();
            uiGroupBox2.SuspendLayout();
            uiGroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textShow
            // 
            textShow.FillColor = Color.White;
            textShow.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textShow.Location = new Point(13, 16);
            textShow.Margin = new Padding(4, 6, 4, 6);
            textShow.MinimumSize = new Size(1, 1);
            textShow.Name = "textShow";
            textShow.Padding = new Padding(2);
            textShow.ScrollBarStyleInherited = false;
            textShow.ShowText = false;
            textShow.Size = new Size(721, 561);
            textShow.TabIndex = 1;
            textShow.TextAlignment = ContentAlignment.MiddleCenter;
            textShow.TextChanged += textShow_TextChanged;
            // 
            // textSend
            // 
            textSend.FillColor = Color.White;
            textSend.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSend.Location = new Point(13, 586);
            textSend.Margin = new Padding(4, 6, 4, 6);
            textSend.MinimumSize = new Size(1, 1);
            textSend.Name = "textSend";
            textSend.Padding = new Padding(2);
            textSend.ScrollBarStyleInherited = false;
            textSend.ShowText = false;
            textSend.Size = new Size(593, 80);
            textSend.TabIndex = 3;
            textSend.TextAlignment = ContentAlignment.MiddleCenter;
            textSend.KeyDown += textSend_KeyDown;
            // 
            // buttonSend
            // 
            buttonSend.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSend.Location = new Point(613, 586);
            buttonSend.MinimumSize = new Size(1, 1);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(121, 83);
            buttonSend.TabIndex = 3;
            buttonSend.Text = "发送";
            buttonSend.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSend.Click += buttonSend_Click;
            // 
            // ClearHistory
            // 
            ClearHistory.BackColor = Color.Transparent;
            ClearHistory.FillColor = Color.DimGray;
            ClearHistory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClearHistory.Location = new Point(752, 16);
            ClearHistory.MinimumSize = new Size(1, 1);
            ClearHistory.Name = "ClearHistory";
            ClearHistory.Radius = 35;
            ClearHistory.RectColor = Color.White;
            ClearHistory.Size = new Size(242, 40);
            ClearHistory.Symbol = 61451;
            ClearHistory.TabIndex = 4;
            ClearHistory.Text = "Clear History";
            ClearHistory.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClearHistory.Click += ClearHistory_Click;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.BackColor = Color.Transparent;
            uiGroupBox1.Controls.Add(uiGroupBox2);
            uiGroupBox1.Controls.Add(textFinishFlag);
            uiGroupBox1.Controls.Add(uiLabel4);
            uiGroupBox1.Controls.Add(textClearHistory);
            uiGroupBox1.Controls.Add(uiLabel3);
            uiGroupBox1.Controls.Add(textObject);
            uiGroupBox1.Controls.Add(uiLabel2);
            uiGroupBox1.Controls.Add(textId);
            uiGroupBox1.Controls.Add(uiLabel1);
            uiGroupBox1.FillColor = Color.Transparent;
            uiGroupBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox1.ForeColor = Color.White;
            uiGroupBox1.Location = new Point(741, 65);
            uiGroupBox1.Margin = new Padding(4, 6, 4, 6);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 36, 0, 0);
            uiGroupBox1.Size = new Size(271, 438);
            uiGroupBox1.TabIndex = 5;
            uiGroupBox1.Text = "输出信息";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox2
            // 
            uiGroupBox2.BackColor = Color.Transparent;
            uiGroupBox2.Controls.Add(textTotalTake);
            uiGroupBox2.Controls.Add(uiLabel6);
            uiGroupBox2.Controls.Add(textReturnTake);
            uiGroupBox2.Controls.Add(uiLabel7);
            uiGroupBox2.Controls.Add(textPromptTake);
            uiGroupBox2.Controls.Add(uiLabel8);
            uiGroupBox2.FillColor = Color.Transparent;
            uiGroupBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox2.ForeColor = Color.White;
            uiGroupBox2.Location = new Point(11, 246);
            uiGroupBox2.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox2.MinimumSize = new Size(1, 1);
            uiGroupBox2.Name = "uiGroupBox2";
            uiGroupBox2.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox2.Size = new Size(245, 181);
            uiGroupBox2.TabIndex = 14;
            uiGroupBox2.Text = "资源使用";
            uiGroupBox2.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // textTotalTake
            // 
            textTotalTake.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textTotalTake.Location = new Point(94, 146);
            textTotalTake.Margin = new Padding(4, 5, 4, 5);
            textTotalTake.MinimumSize = new Size(1, 16);
            textTotalTake.Name = "textTotalTake";
            textTotalTake.Padding = new Padding(5);
            textTotalTake.ShowText = false;
            textTotalTake.Size = new Size(127, 23);
            textTotalTake.TabIndex = 11;
            textTotalTake.TextAlignment = ContentAlignment.MiddleLeft;
            textTotalTake.Watermark = "";
            // 
            // uiLabel6
            // 
            uiLabel6.BackColor = Color.Transparent;
            uiLabel6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel6.ForeColor = Color.White;
            uiLabel6.Location = new Point(3, 146);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(100, 23);
            uiLabel6.TabIndex = 10;
            uiLabel6.Text = "总计占用";
            uiLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textReturnTake
            // 
            textReturnTake.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textReturnTake.Location = new Point(94, 97);
            textReturnTake.Margin = new Padding(4, 5, 4, 5);
            textReturnTake.MinimumSize = new Size(1, 16);
            textReturnTake.Name = "textReturnTake";
            textReturnTake.Padding = new Padding(5);
            textReturnTake.ShowText = false;
            textReturnTake.Size = new Size(127, 23);
            textReturnTake.TabIndex = 9;
            textReturnTake.TextAlignment = ContentAlignment.MiddleLeft;
            textReturnTake.Watermark = "";
            // 
            // uiLabel7
            // 
            uiLabel7.BackColor = Color.Transparent;
            uiLabel7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel7.ForeColor = Color.White;
            uiLabel7.Location = new Point(3, 97);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new Size(100, 23);
            uiLabel7.TabIndex = 8;
            uiLabel7.Text = "返回占用";
            uiLabel7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textPromptTake
            // 
            textPromptTake.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPromptTake.Location = new Point(94, 48);
            textPromptTake.Margin = new Padding(4, 5, 4, 5);
            textPromptTake.MinimumSize = new Size(1, 16);
            textPromptTake.Name = "textPromptTake";
            textPromptTake.Padding = new Padding(5);
            textPromptTake.ShowText = false;
            textPromptTake.Size = new Size(127, 23);
            textPromptTake.TabIndex = 7;
            textPromptTake.TextAlignment = ContentAlignment.MiddleLeft;
            textPromptTake.Watermark = "";
            // 
            // uiLabel8
            // 
            uiLabel8.BackColor = Color.Transparent;
            uiLabel8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel8.ForeColor = Color.White;
            uiLabel8.Location = new Point(3, 48);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new Size(100, 23);
            uiLabel8.TabIndex = 6;
            uiLabel8.Text = "提示词占用";
            uiLabel8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textFinishFlag
            // 
            textFinishFlag.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textFinishFlag.Location = new Point(106, 195);
            textFinishFlag.Margin = new Padding(4, 5, 4, 5);
            textFinishFlag.MinimumSize = new Size(1, 16);
            textFinishFlag.Name = "textFinishFlag";
            textFinishFlag.Padding = new Padding(5);
            textFinishFlag.ShowText = false;
            textFinishFlag.Size = new Size(150, 29);
            textFinishFlag.TabIndex = 13;
            textFinishFlag.TextAlignment = ContentAlignment.MiddleLeft;
            textFinishFlag.Watermark = "";
            // 
            // uiLabel4
            // 
            uiLabel4.BackColor = Color.Transparent;
            uiLabel4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel4.ForeColor = Color.White;
            uiLabel4.Location = new Point(3, 195);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(100, 23);
            uiLabel4.TabIndex = 12;
            uiLabel4.Text = "结束类型";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textClearHistory
            // 
            textClearHistory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textClearHistory.Location = new Point(106, 146);
            textClearHistory.Margin = new Padding(4, 5, 4, 5);
            textClearHistory.MinimumSize = new Size(1, 16);
            textClearHistory.Name = "textClearHistory";
            textClearHistory.Padding = new Padding(5);
            textClearHistory.ShowText = false;
            textClearHistory.Size = new Size(150, 29);
            textClearHistory.TabIndex = 11;
            textClearHistory.TextAlignment = ContentAlignment.MiddleLeft;
            textClearHistory.Watermark = "";
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = Color.Transparent;
            uiLabel3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.ForeColor = Color.White;
            uiLabel3.Location = new Point(3, 146);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(100, 23);
            uiLabel3.TabIndex = 10;
            uiLabel3.Text = "清除历史";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textObject
            // 
            textObject.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textObject.Location = new Point(106, 97);
            textObject.Margin = new Padding(4, 5, 4, 5);
            textObject.MinimumSize = new Size(1, 16);
            textObject.Name = "textObject";
            textObject.Padding = new Padding(5);
            textObject.ShowText = false;
            textObject.Size = new Size(150, 29);
            textObject.TabIndex = 9;
            textObject.TextAlignment = ContentAlignment.MiddleLeft;
            textObject.Watermark = "";
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.Transparent;
            uiLabel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.White;
            uiLabel2.Location = new Point(3, 97);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(100, 23);
            uiLabel2.TabIndex = 8;
            uiLabel2.Text = "对象名";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textId
            // 
            textId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textId.Location = new Point(106, 48);
            textId.Margin = new Padding(4, 5, 4, 5);
            textId.MinimumSize = new Size(1, 16);
            textId.Name = "textId";
            textId.Padding = new Padding(5);
            textId.ShowText = false;
            textId.Size = new Size(150, 29);
            textId.TabIndex = 7;
            textId.TextAlignment = ContentAlignment.MiddleLeft;
            textId.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            uiLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.White;
            uiLabel1.Location = new Point(3, 48);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(100, 23);
            uiLabel1.TabIndex = 6;
            uiLabel1.Text = "对话编号";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox3
            // 
            uiGroupBox3.BackColor = Color.Transparent;
            uiGroupBox3.Controls.Add(uiSymbolButton1);
            uiGroupBox3.Controls.Add(switchSearch);
            uiGroupBox3.Controls.Add(trackBarRandom);
            uiGroupBox3.Controls.Add(uiLabel5);
            uiGroupBox3.Controls.Add(uiLabel10);
            uiGroupBox3.FillColor = Color.Transparent;
            uiGroupBox3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox3.ForeColor = Color.White;
            uiGroupBox3.Location = new Point(744, 515);
            uiGroupBox3.Margin = new Padding(4, 6, 4, 6);
            uiGroupBox3.MinimumSize = new Size(1, 1);
            uiGroupBox3.Name = "uiGroupBox3";
            uiGroupBox3.Padding = new Padding(0, 36, 0, 0);
            uiGroupBox3.Size = new Size(277, 151);
            uiGroupBox3.TabIndex = 15;
            uiGroupBox3.Text = "模型调整";
            uiGroupBox3.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // uiSymbolButton1
            // 
            uiSymbolButton1.BackColor = Color.Transparent;
            uiSymbolButton1.FillColor = Color.DimGray;
            uiSymbolButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiSymbolButton1.Location = new Point(20, 115);
            uiSymbolButton1.MinimumSize = new Size(1, 1);
            uiSymbolButton1.Name = "uiSymbolButton1";
            uiSymbolButton1.Radius = 19;
            uiSymbolButton1.RectColor = Color.White;
            uiSymbolButton1.Size = new Size(233, 28);
            uiSymbolButton1.Symbol = 61450;
            uiSymbolButton1.TabIndex = 16;
            uiSymbolButton1.Text = "设置";
            uiSymbolButton1.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiSymbolButton1.Click += uiSymbolButton1_Click;
            // 
            // switchSearch
            // 
            switchSearch.ActiveColor = Color.Lime;
            switchSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            switchSearch.Location = new Point(103, 74);
            switchSearch.MinimumSize = new Size(1, 1);
            switchSearch.Name = "switchSearch";
            switchSearch.Size = new Size(75, 29);
            switchSearch.TabIndex = 17;
            switchSearch.Text = "uiSwitch1";
            // 
            // trackBarRandom
            // 
            trackBarRandom.FillColor = Color.DimGray;
            trackBarRandom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            trackBarRandom.Location = new Point(106, 39);
            trackBarRandom.MinimumSize = new Size(1, 1);
            trackBarRandom.Name = "trackBarRandom";
            trackBarRandom.Size = new Size(150, 29);
            trackBarRandom.TabIndex = 16;
            trackBarRandom.Text = "uiTrackBar1";
            // 
            // uiLabel5
            // 
            uiLabel5.BackColor = Color.Transparent;
            uiLabel5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel5.ForeColor = Color.White;
            uiLabel5.Location = new Point(3, 71);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(75, 29);
            uiLabel5.TabIndex = 8;
            uiLabel5.Text = "禁用搜索";
            uiLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            uiLabel10.BackColor = Color.Transparent;
            uiLabel10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel10.ForeColor = Color.White;
            uiLabel10.Location = new Point(8, 39);
            uiLabel10.Name = "uiLabel10";
            uiLabel10.Size = new Size(100, 23);
            uiLabel10.TabIndex = 6;
            uiLabel10.Text = "随机性";
            uiLabel10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1039, 681);
            Controls.Add(uiGroupBox3);
            Controls.Add(uiGroupBox1);
            Controls.Add(ClearHistory);
            Controls.Add(buttonSend);
            Controls.Add(textSend);
            Controls.Add(textShow);
            Name = "Form1";
            Text = "Ernie Chat";
            Load += Form1_Load;
            uiGroupBox1.ResumeLayout(false);
            uiGroupBox2.ResumeLayout(false);
            uiGroupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIRichTextBox textShow;
        private Sunny.UI.UIRichTextBox textSend;
        private Sunny.UI.UIButton buttonSend;
        private Sunny.UI.UISymbolButton ClearHistory;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UITextBox textTotalTake;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox textReturnTake;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox textPromptTake;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox textFinishFlag;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox textClearHistory;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox textObject;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox textId;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISwitch switchSearch;
        private Sunny.UI.UITrackBar trackBarRandom;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel10;
    }
}