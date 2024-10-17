namespace WF_DZ5
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            workStartLabel = new Label();
            startDateTimePicker = new DateTimePicker();
            workCompletionLabel = new Label();
            endDateTimePicker = new DateTimePicker();
            oneDayPriceLabel = new Label();
            coastTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            totalPriceLabel = new Label();
            errorProvider1 = new ErrorProvider(components);
            comboBox1 = new ComboBox();
            choiseLanguageLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // workStartLabel
            // 
            resources.ApplyResources(workStartLabel, "workStartLabel");
            workStartLabel.Name = "workStartLabel";
            // 
            // startDateTimePicker
            // 
            resources.ApplyResources(startDateTimePicker, "startDateTimePicker");
            startDateTimePicker.CalendarForeColor = Color.Black;
            startDateTimePicker.CalendarMonthBackground = Color.White;
            startDateTimePicker.CalendarTitleForeColor = Color.Black;
            startDateTimePicker.CalendarTrailingForeColor = Color.LightSlateGray;
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.ValueChanged += startDateTimePicker_ValueChanged;
            startDateTimePicker.Leave += startDateTimePicker_ValueChanged;
            // 
            // workCompletionLabel
            // 
            resources.ApplyResources(workCompletionLabel, "workCompletionLabel");
            workCompletionLabel.Name = "workCompletionLabel";
            // 
            // endDateTimePicker
            // 
            resources.ApplyResources(endDateTimePicker, "endDateTimePicker");
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.ValueChanged += endDateTimePicker_ValueChanged;
            endDateTimePicker.Leave += endDateTimePicker_ValueChanged;
            // 
            // oneDayPriceLabel
            // 
            resources.ApplyResources(oneDayPriceLabel, "oneDayPriceLabel");
            oneDayPriceLabel.Name = "oneDayPriceLabel";
            // 
            // coastTextBox
            // 
            resources.ApplyResources(coastTextBox, "coastTextBox");
            coastTextBox.Name = "coastTextBox";
            coastTextBox.TextChanged += coastTextBox_TextChanged;
            coastTextBox.Leave += coastTextBox_TextChanged;
            // 
            // emailLabel
            // 
            resources.ApplyResources(emailLabel, "emailLabel");
            emailLabel.Name = "emailLabel";
            // 
            // emailTextBox
            // 
            resources.ApplyResources(emailTextBox, "emailTextBox");
            emailTextBox.Name = "emailTextBox";
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            emailTextBox.Leave += emailTextBox_TextChanged;
            // 
            // totalPriceLabel
            // 
            resources.ApplyResources(totalPriceLabel, "totalPriceLabel");
            totalPriceLabel.Name = "totalPriceLabel";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // comboBox1
            // 
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { resources.GetString("comboBox1.Items"), resources.GetString("comboBox1.Items1") });
            comboBox1.Name = "comboBox1";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // choiseLanguageLabel
            // 
            resources.ApplyResources(choiseLanguageLabel, "choiseLanguageLabel");
            choiseLanguageLabel.Name = "choiseLanguageLabel";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(totalPriceLabel);
            Controls.Add(emailTextBox);
            Controls.Add(choiseLanguageLabel);
            Controls.Add(emailLabel);
            Controls.Add(coastTextBox);
            Controls.Add(oneDayPriceLabel);
            Controls.Add(endDateTimePicker);
            Controls.Add(workCompletionLabel);
            Controls.Add(startDateTimePicker);
            Controls.Add(workStartLabel);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label workStartLabel;
        private DateTimePicker startDateTimePicker;
        private Label workCompletionLabel;
        private DateTimePicker endDateTimePicker;
        private Label oneDayPriceLabel;
        private TextBox coastTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label totalPriceLabel;
        private ErrorProvider errorProvider1;
        private ComboBox comboBox1;
        private Label choiseLanguageLabel;
    }
}
