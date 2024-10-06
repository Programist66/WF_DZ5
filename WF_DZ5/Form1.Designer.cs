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
            label1 = new Label();
            startDateTimePicker = new DateTimePicker();
            label2 = new Label();
            endDateTimePicker = new DateTimePicker();
            label3 = new Label();
            coastTextBox = new TextBox();
            label4 = new Label();
            emailTextBox = new TextBox();
            totalPriceLabel = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(32, 64);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 0;
            label1.Text = "Дата начала работ";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Anchor = AnchorStyles.None;
            startDateTimePicker.CalendarForeColor = Color.Black;
            startDateTimePicker.CalendarMonthBackground = Color.White;
            startDateTimePicker.CalendarTitleForeColor = Color.Black;
            startDateTimePicker.CalendarTrailingForeColor = Color.LightSlateGray;
            startDateTimePicker.Location = new Point(352, 64);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(240, 23);
            startDateTimePicker.TabIndex = 1;
            startDateTimePicker.ValueChanged += startDateTimePicker_ValueChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(32, 112);
            label2.Name = "label2";
            label2.Size = new Size(209, 25);
            label2.TabIndex = 0;
            label2.Text = "Дата окончания работ";
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Anchor = AnchorStyles.None;
            endDateTimePicker.Location = new Point(352, 112);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(240, 23);
            endDateTimePicker.TabIndex = 1;
            endDateTimePicker.ValueChanged += endDateTimePicker_ValueChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(32, 160);
            label3.Name = "label3";
            label3.Size = new Size(207, 25);
            label3.TabIndex = 2;
            label3.Text = "Стоимость одного дня";
            // 
            // coastTextBox
            // 
            coastTextBox.Anchor = AnchorStyles.None;
            coastTextBox.Location = new Point(352, 160);
            coastTextBox.Name = "coastTextBox";
            coastTextBox.Size = new Size(240, 23);
            coastTextBox.TabIndex = 3;
            coastTextBox.TextChanged += coastTextBox_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(32, 208);
            label4.Name = "label4";
            label4.Size = new Size(240, 25);
            label4.TabIndex = 2;
            label4.Text = "Адрес электронной почты";
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.None;
            emailTextBox.Location = new Point(352, 208);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(240, 23);
            emailTextBox.TabIndex = 3;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.Anchor = AnchorStyles.None;
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            totalPriceLabel.Location = new Point(192, 352);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(231, 30);
            totalPriceLabel.TabIndex = 4;
            totalPriceLabel.Text = "Итоговая стоимость: 0";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 450);
            Controls.Add(totalPriceLabel);
            Controls.Add(emailTextBox);
            Controls.Add(label4);
            Controls.Add(coastTextBox);
            Controls.Add(label3);
            Controls.Add(endDateTimePicker);
            Controls.Add(label2);
            Controls.Add(startDateTimePicker);
            Controls.Add(label1);
            Name = "Form1";
            Text = "калькулятор стоимости работ";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker startDateTimePicker;
        private Label label2;
        private DateTimePicker endDateTimePicker;
        private Label label3;
        private TextBox coastTextBox;
        private Label label4;
        private TextBox emailTextBox;
        private Label totalPriceLabel;
        private ErrorProvider errorProvider1;
    }
}
