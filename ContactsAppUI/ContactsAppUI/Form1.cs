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
        public Project projectData;

        public Form1()
        {
            InitializeComponent();

            projectData = new Project();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialization of 10 contacts
            Contact[] contacts = new Contact[10];

            for (int i = 0; i < 10; i++)
            {
                contacts[i] = new Contact(new string[3] { "A" + i, "D", "N" }, 
                    new PhoneNumber("999", "6192838"), 
                    new DateTime(1999, 06, 12),
                    "GenericEmail@gmail.com",
                    "123456");
                projectData.ContactList.Add(contacts[i]);
            }

            //Save to file
            ProjectManager.SaveToFile(projectData, ProjectManager.FilePath);

            //Delete initialized contacts
            projectData = new Project();

            //Loading contacs from file
            projectData = ProjectManager.LoadFromFile(ProjectManager.FilePath);
        }


    }
}
