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

        public Contact currentContact;

        private void EditContactForm_Load(object sender, EventArgs e)
        {
            if (currentContact != null)
            {
                NameTextBox.Text = currentContact.Name[0];
                MiddleNameTextBox.Text = currentContact.Name[1];
                LastNameTextBox.Text = currentContact.Name[2];

                BithdayDateTimePicker.Text = currentContact.Birthday.ToString();

                PhoneTextBox.Text = currentContact.PhoneNumber.ZoneCode + currentContact.PhoneNumber.Number;

                EmailTextBox.Text = currentContact.Email;
                VKIDTextBox.Text = currentContact.VKID;
            }
            else
            {
                currentContact = new Contact();
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                currentContact.Name[0] = NameTextBox.Text;
                currentContact.Name[1] = MiddleNameTextBox.Text;
                currentContact.Name[2] = LastNameTextBox.Text;

                currentContact.Birthday = BithdayDateTimePicker.Value;

                currentContact.PhoneNumber.ZoneCode = PhoneTextBox.Text.Substring(0, 3);
                currentContact.PhoneNumber.Number = PhoneTextBox.Text.Substring(3, 7);

                currentContact.Email = EmailTextBox.Text;
                currentContact.VKID = VKIDTextBox.Text;

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
