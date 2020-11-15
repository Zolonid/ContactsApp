using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        public string _filePath;
        public static string _fileName = "Contacts.data";
        private BindingList<Contact> _bindingList;

        public MainForm()
        {
            InitializeComponent();

            _filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //_projectData = new Project();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(_filePath + @"\" + _fileName))
            {
                _bindingList = new BindingList<Contact>(ProjectManager.LoadFromFile(_filePath + @"\" + _fileName).ContactList);

                //RefreshListBox();
            }
            else
            {
                _bindingList = new BindingList<Contact>();
            }

            ContactsListBox.DataSource = _bindingList;
        }

        /// <summary>
        /// Reloads contacts info to textboxes on MainForm
        /// </summary>
        private void RefreshContactInfo()
        {
            if (_bindingList.Count != 0)
            {
                var index = ContactsListBox.SelectedIndex;

                Contact selectedContact = index == -1 ? _bindingList.Last() : _bindingList[index];

                NameTextBox.Text = selectedContact.Name[0];
                MiddleNameTextBox.Text = selectedContact.Name[1];
                LastNameTextBox.Text = selectedContact.Name[2];

                BithdayDateTimePicker.Text = selectedContact.Birthday.ToString(CultureInfo.InvariantCulture);

                PhoneMaskedTextBox.Text = selectedContact.PhoneNumber.ZoneCode + selectedContact.PhoneNumber.Number;

                EmailTextBox.Text = selectedContact.Email;
                VKIDTextBox.Text = selectedContact.VKID;
            }
            else
            {
                ClearContactInfo();
            }
        }

        /// <summary>
        /// Clears textboxes on MainForm
        /// </summary>
        private void ClearContactInfo()
        {
            NameTextBox.Text = "";
            MiddleNameTextBox.Text = "";
            LastNameTextBox.Text = "";

            BithdayDateTimePicker.Text = "";

            PhoneMaskedTextBox.Text = "";

            EmailTextBox.Text = "";
            VKIDTextBox.Text = "";
        }

        /// <summary>
        /// Demo for json serialization and deserialization.
        /// </summary>
        void JsonDemo()
        {
            //Initialization of 10 contacts
            Contact[] contacts = new Contact[10];

            for (int i = 0; i < 10; i++)
            {
                contacts[i] = new Contact(
                    new string[3] { "A" + i, "D", "N" },
                    new PhoneNumber("999", "6192838"),
                    new DateTime(1999, 06, 12),
                    "GenericEmail@gmail.com",
                    "123456");
                _bindingList.Add(contacts[i]);
            }

            //Save to file
            ProjectManager.SaveToFile(new Project(_bindingList.ToList()), _filePath + @"\" + _fileName);

            //Delete initialized contacts
            _bindingList = null;

            //Loading contacs from file
            _bindingList = new BindingList<Contact>(ProjectManager.LoadFromFile(_filePath + @"\" + _fileName).ContactList);
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            EditContactForm editContactForm = new EditContactForm();

            DialogResult dr = editContactForm.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                editContactForm.Close();
            }
            else if (dr == DialogResult.OK)
            {
                _bindingList.Add(editContactForm.CurrentContact);
                editContactForm.Close();

                RefreshContactInfo();
            }
        }

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            EditContactForm editContactForm = new EditContactForm();

            editContactForm.CurrentContact = _bindingList[ContactsListBox.SelectedIndex];

            DialogResult dr = editContactForm.ShowDialog(this);
            switch (dr)
            {
                case DialogResult.Cancel:
                    editContactForm.Close();
                    break;
                case DialogResult.OK:
                    _bindingList[ContactsListBox.SelectedIndex] = editContactForm.CurrentContact;
                    editContactForm.Close();
                    break;
            }

            RefreshContactInfo();
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshContactInfo();
        }

        private void DeleteContactButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Do you want to delete selected contact?",
                "Confirmation",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _bindingList.Remove((Contact) ContactsListBox.SelectedItem);
                RefreshContactInfo();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog()
            {
                AddExtension = true,
                Filter = "Saved Contacts| *.data| All Files| *.*",
                FileName = "Contacts"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
                ProjectManager.SaveToFile(new Project(_bindingList.ToList()), fileDialog.FileName);
        }

        private void LoadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Filter = "Saved Contacts| *.data| All Files| *.*"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _bindingList = new BindingList<Contact>(ProjectManager.LoadFromFile(fileDialog.FileName).ContactList);
                ContactsListBox.DataSource = _bindingList;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();

        }
    }
}
