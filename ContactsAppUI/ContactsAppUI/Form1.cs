using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class Form1 : Form
    {
        public readonly string _filePath;
        public static string _fileName = "json.txt";
        public Project _projectData;

        public Form1()
        {
            InitializeComponent();

            _filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            _projectData = new Project();
        }

        private void Form1_Load(object sender, EventArgs e)
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


    }
}
