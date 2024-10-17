using System.Globalization;
using System.Resources;
using System.Text.RegularExpressions;

namespace WF_DZ5
{
    public partial class Form1 : Form
    {
        Regex pricePattern = new Regex(@"^[1-9][0-9]*(\.[0-9]+)?$");
        Regex emailPattern = new Regex(@"^([A-Za-z0-9][!#$%&’r;+\-.=?^^_`{}½~]?){0,63}[A-Za-z0-9]@([A-Za-z0-9][\-]?)+\.([A-Za-z0-9][\-]?)*[A-Za-z0-9]$");
        Localizable Localizable = new(new ResourceManager(typeof(Form1)));

        public Form1()
        {
            InitializeComponent();
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateErrorProvider();
            CalculateTotalPrice();
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateErrorProvider();
            CalculateTotalPrice();
        }

        private void UpdateErrorProvider() 
        {
            errorProvider1.SetError(
                startDateTimePicker, 
                startDateTimePicker.Value >= DateTime.Today ?
                null : Localizable.LocalizableString("StartDateInThePass")
                );
            if (endDateTimePicker.Value < startDateTimePicker.Value)
            {
                errorProvider1.SetError(endDateTimePicker, Localizable.LocalizableString("StartDateLaterEndDate"));
            }
            else if (endDateTimePicker.Value < DateTime.Today)
            {
                errorProvider1.SetError(endDateTimePicker,Localizable.LocalizableString("EndDateInThePass"));
            }
            else
            {
                errorProvider1.SetError(endDateTimePicker, null);
            }
            if (!pricePattern.IsMatch(coastTextBox.Text))
            {
                errorProvider1.SetError(coastTextBox, Localizable.LocalizableString("IncorrectNumber"));
                coastTextBox.BackColor = Color.FromArgb(255, 128, 128);
            }
            else
            {
                errorProvider1.SetError(coastTextBox, null);
                coastTextBox.BackColor = Color.White;
            }
            if (!emailPattern.IsMatch(emailTextBox.Text) || emailTextBox.Text.Length > 319)
            {
                errorProvider1.SetError(emailTextBox, Localizable.LocalizableString("IncorrectEmail"));
                emailTextBox.BackColor = Color.FromArgb(255, 128, 128);
            }
            else
            {
                errorProvider1.SetError(emailTextBox, null);
                emailTextBox.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        private void coastTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateErrorProvider();
            CalculateTotalPrice();
        }
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateErrorProvider();
        }

        private int CalculateTotalPrice()
        {
            if (startDateTimePicker.Value < DateTime.Today)
            {
                return 0;
            }
            if (endDateTimePicker.Value < DateTime.Today || endDateTimePicker.Value < startDateTimePicker.Value)
            {
                return 0;
            }
            if (!pricePattern.IsMatch(coastTextBox.Text))
            {
                return 0;
            }
            int totalPrice = (int)Math.Ceiling((endDateTimePicker.Value - startDateTimePicker.Value).TotalDays) * Int32.Parse(coastTextBox.Text);
            Localizable.ChangeLanguage(totalPriceLabel, "TotalPriceLabel", totalPrice.ToString());
            return totalPrice;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is null)
            {
                return;
            }
            if ((string)comboBox1.SelectedItem == "Русский")
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("Ru-ru");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("Ru-ru");
                Localizable.resourceManager = new ResourceManager(typeof(Form1));
            }
            else if ((string)comboBox1.SelectedItem == "English") 
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("En-en");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("En-en");
                Localizable.resourceManager = new ResourceManager(typeof(Form1));
            }
            Localizable.ChangeLanguage(choiseLanguageLabel, "ChoiseLanguage");
            Localizable.ChangeLanguage(workStartLabel, "StartWorkLabel");
            Localizable.ChangeLanguage(workCompletionLabel, "EndWorkLabel");
            Localizable.ChangeLanguage(oneDayPriceLabel, "DayPriceLabel");
            Localizable.ChangeLanguage(emailLabel, "EmailAddresLabel");
            Localizable.ChangeLanguage(totalPriceLabel, "TotalPriceLabel", CalculateTotalPrice().ToString());
            UpdateErrorProvider();
        }
    }
}
