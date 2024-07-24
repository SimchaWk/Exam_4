namespace ChiefRabbinateQueries
{
    partial class MainForm
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
            YearLabel = new Label();
            YearComboBox = new ComboBox();
            MonthComboBox = new ComboBox();
            MonthLabel = new Label();
            MonthDayComboBox = new ComboBox();
            MonthDayLabel = new Label();
            WeekDayComboBox = new ComboBox();
            WeekDayLabel = new Label();
            ExitButton = new Button();
            ResultButton = new Button();
            ResultLabel = new Label();
            SuspendLayout();
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Location = new Point(221, 128);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(51, 30);
            YearLabel.TabIndex = 0;
            YearLabel.Text = "שנה";
            // 
            // YearComboBox
            // 
            YearComboBox.FormattingEnabled = true;
            YearComboBox.Items.AddRange(new object[] { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג" });
            YearComboBox.Location = new Point(174, 175);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.Size = new Size(155, 38);
            YearComboBox.TabIndex = 1;
            // 
            // MonthComboBox
            // 
            MonthComboBox.FormattingEnabled = true;
            MonthComboBox.Items.AddRange(new object[] { "תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" });
            MonthComboBox.Location = new Point(390, 175);
            MonthComboBox.Name = "MonthComboBox";
            MonthComboBox.Size = new Size(155, 38);
            MonthComboBox.TabIndex = 3;
            // 
            // MonthLabel
            // 
            MonthLabel.AutoSize = true;
            MonthLabel.Location = new Point(437, 128);
            MonthLabel.Name = "MonthLabel";
            MonthLabel.Size = new Size(59, 30);
            MonthLabel.TabIndex = 2;
            MonthLabel.Text = "חודש";
            // 
            // MonthDayComboBox
            // 
            MonthDayComboBox.FormattingEnabled = true;
            MonthDayComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            MonthDayComboBox.Location = new Point(616, 175);
            MonthDayComboBox.Name = "MonthDayComboBox";
            MonthDayComboBox.Size = new Size(155, 38);
            MonthDayComboBox.TabIndex = 5;
            // 
            // MonthDayLabel
            // 
            MonthDayLabel.AutoSize = true;
            MonthDayLabel.Location = new Point(639, 128);
            MonthDayLabel.Name = "MonthDayLabel";
            MonthDayLabel.Size = new Size(118, 30);
            MonthDayLabel.TabIndex = 4;
            MonthDayLabel.Text = "היום בחודש";
            // 
            // WeekDayComboBox
            // 
            WeekDayComboBox.FormattingEnabled = true;
            WeekDayComboBox.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" });
            WeekDayComboBox.Location = new Point(838, 175);
            WeekDayComboBox.Name = "WeekDayComboBox";
            WeekDayComboBox.Size = new Size(155, 38);
            WeekDayComboBox.TabIndex = 7;
            // 
            // WeekDayLabel
            // 
            WeekDayLabel.AutoSize = true;
            WeekDayLabel.Location = new Point(856, 128);
            WeekDayLabel.Name = "WeekDayLabel";
            WeekDayLabel.Size = new Size(119, 30);
            WeekDayLabel.TabIndex = 6;
            WeekDayLabel.Text = "היום בשבוע";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(12, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(131, 40);
            ExitButton.TabIndex = 8;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButtonClick;
            // 
            // ResultButton
            // 
            ResultButton.Location = new Point(511, 308);
            ResultButton.Name = "ResultButton";
            ResultButton.Size = new Size(131, 40);
            ResultButton.TabIndex = 9;
            ResultButton.Text = "הצג תוצאה";
            ResultButton.UseVisualStyleBackColor = true;
            ResultButton.Click += ResultButtonClick;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(152, 460);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(0, 30);
            ResultLabel.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 600);
            Controls.Add(ResultLabel);
            Controls.Add(ResultButton);
            Controls.Add(ExitButton);
            Controls.Add(WeekDayComboBox);
            Controls.Add(WeekDayLabel);
            Controls.Add(MonthDayComboBox);
            Controls.Add(MonthDayLabel);
            Controls.Add(MonthComboBox);
            Controls.Add(MonthLabel);
            Controls.Add(YearComboBox);
            Controls.Add(YearLabel);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label YearLabel;
        private ComboBox YearComboBox;
        private ComboBox MonthComboBox;
        private Label MonthLabel;
        private ComboBox MonthDayComboBox;
        private Label MonthDayLabel;
        private ComboBox WeekDayComboBox;
        private Label WeekDayLabel;
        private Button ExitButton;
        private Button ResultButton;
        private Label ResultLabel;
    }
}
