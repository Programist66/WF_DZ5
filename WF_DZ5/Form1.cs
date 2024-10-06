using System.Text.RegularExpressions;

namespace WF_DZ5
{
    public partial class Form1 : Form
    {
        Regex pricePattern = new Regex(@"^[1-9][0-9]*(\.[0-9]+)?$");
        Regex emailPattern = new Regex(@"^([A-Za-z0-9][!#$%&’r;+\-.=?^^_`{}½~]?){0,63}[A-Za-z0-9]@([A-Za-z0-9][\-]?)+\.([A-Za-z0-9][\-]?)*[A-Za-z0-9]$");

        public Form1()
        {
            InitializeComponent();
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(startDateTimePicker, startDateTimePicker.Value >= DateTime.Today ? null : "Дата начала работ должна быть в будущем");
            CalculateTotalPrice();
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(endDateTimePicker, endDateTimePicker.Value >= DateTime.Today ? null : "Дата окончания работ должна быть в будущем");
            errorProvider1.SetError(endDateTimePicker, endDateTimePicker.Value > startDateTimePicker.Value ? null : "Дата окончания работ должна быть позже даты начала работ");
            CalculateTotalPrice();
        }

        private void coastTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!pricePattern.IsMatch(coastTextBox.Text))
            {
                errorProvider1.SetError(coastTextBox, "Некорректный формат числа");
                coastTextBox.BackColor = Color.FromArgb(255, 128, 128);
            }
            else
            {
                errorProvider1.SetError(coastTextBox, null);
                coastTextBox.BackColor = Color.White;
            }
            CalculateTotalPrice();
        }
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!emailPattern.IsMatch(emailTextBox.Text) || emailTextBox.Text.Length > 319)
            {
                errorProvider1.SetError(emailTextBox, "Некорректный формат почты");
                emailTextBox.BackColor = Color.FromArgb(255, 128, 128);
            }
            else
            {
                errorProvider1.SetError(emailTextBox, null);
                emailTextBox.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void CalculateTotalPrice()
        {
            if (startDateTimePicker.Value < DateTime.Today)
            {
                return;
            }
            if (endDateTimePicker.Value < DateTime.Today || endDateTimePicker.Value < startDateTimePicker.Value)
            {
                return;
            }
            if (!pricePattern.IsMatch(coastTextBox.Text))
            {
                return;
            }
            totalPriceLabel.Text = $"Итоговая стоимость: {(int)Math.Ceiling((endDateTimePicker.Value - startDateTimePicker.Value).TotalDays) * Int32.Parse(coastTextBox.Text)}";
        }        
    }
}
