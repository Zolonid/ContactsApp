using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public static string _fileName = "json.txt";
        public Project _projectData;

        public MainForm()
        {
            InitializeComponent();

            _filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            _projectData = new Project();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists(_filePath + @"\" + _fileName)){
                _projectData = ProjectManager.LoadFromFile(_filePath + @"\" + _fileName);

                RefreshListBox();
            }
        }
        /// <summary>
        /// Reloads contacts from _projectData to listbox on MainForm
        /// </summary>
        private void RefreshListBox()
        {
            ContactsListBox.Items.Clear();

            foreach (var contact in _projectData.ContactList)
            {
                string Name = contact.Name[0] + ' ' + contact.Name[1] + ' ' + contact.Name[2];

                ContactsListBox.Items.Add(Name);
            }

        }

        /// <summary>
        /// Reloads contacts info to textboxes on MainForm
        /// </summary>
        private void RefreshContactInfo()
        {
            if (_projectData.ContactList.Count != 0)
            {
                var index = ContactsListBox.SelectedIndex;
                Contact selectedContact = index == -1 ? _projectData.ContactList.Last() : _projectData.ContactList[index];
                NameTextBox.Text = selectedContact.Name[0];
                MiddleNameTextBox.Text = selectedContact.Name[1];
                LastNameTextBox.Text = selectedContact.Name[2];

                BithdayDateTimePicker.Text = selectedContact.Birthday.ToString();

                PhoneTextBox.Text = selectedContact.PhoneNumber.ZoneCode + selectedContact.PhoneNumber.Number;

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

            PhoneTextBox.Text = "";

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
                _projectData.ContactList.Add(contacts[i]);
            }

            //Save to file
            ProjectManager.SaveToFile(_projectData, _filePath + @"\" + _fileName);

            //Delete initialized contacts
            _projectData = null;

            //Loading contacs from file
            _projectData = ProjectManager.LoadFromFile(_filePath + @"\" + _fileName);
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            int index = ContactsListBox.SelectedIndex;
            var editContactForm = new EditContactForm();
            DialogResult dr = editContactForm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                editContactForm.Close();
            }
            else if (dr == DialogResult.OK)
            {
                _projectData.ContactList.Add(editContactForm.currentContact);
                editContactForm.Close();

                RefreshListBox();

                RefreshContactInfo();
            }
        }

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            int index = ContactsListBox.SelectedIndex;
            EditContactForm editContactForm = new EditContactForm();
            editContactForm.currentContact = _projectData.ContactList[ContactsListBox.SelectedIndex];
            DialogResult dr = editContactForm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                editContactForm.Close();
            }
            else if (dr == DialogResult.OK)
            {
                _projectData.ContactList[ContactsListBox.SelectedIndex] = editContactForm.currentContact;
                editContactForm.Close();
            }

            RefreshListBox();

            RefreshContactInfo();
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshContactInfo();
        }

        private void DeleteContactButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete selected contact?", "Confirmation",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _projectData.ContactList.RemoveAt(ContactsListBox.SelectedIndex);

                RefreshListBox();

                ClearContactInfo();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
                ProjectManager.SaveToFile(_projectData, folderDialog.SelectedPath + @"\" + _fileName);
        }

        private void LoadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _projectData = ProjectManager.LoadFromFile(fileDialog.FileName);
                RefreshListBox();
            }


        }


    }
}
