using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class EditContactForm : Form
    {
        public EditContactForm()
        {
            InitializeComponent();
        }

        public Contact CurrentContact;

        private void EditContactForm_Load(object sender, EventArgs e)
        {
            if (CurrentContact != null)
            {
                var name = CurrentContact.Name;
                NameTextBox.Text = name[0];
                MiddleNameTextBox.Text = name[1];
                LastNameTextBox.Text = name[2];

                BithdayDateTimePicker.Text = CurrentContact.Birthday.ToString();

                PhoneMaskedTextBox.Text = CurrentContact.PhoneNumber.ZoneCode + CurrentContact.PhoneNumber.Number;

                EmailTextBox.Text = CurrentContact.Email;
                VKIDTextBox.Text = CurrentContact.VKID;
            }
            else
            {
                CurrentContact = new Contact();
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentContact.Name = new[] {NameTextBox.Text, MiddleNameTextBox.Text, LastNameTextBox.Text};

                CurrentContact.Birthday = BithdayDateTimePicker.Value;

                CurrentContact.PhoneNumber.ZoneCode = PhoneMaskedTextBox.Text.Substring(0, 3);
                CurrentContact.PhoneNumber.Number = PhoneMaskedTextBox.Text.Substring(3, 7);

                CurrentContact.Email = EmailTextBox.Text;
                CurrentContact.VKID = VKIDTextBox.Text;

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BanSpecialSymbols(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9а-яА-Я\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}
