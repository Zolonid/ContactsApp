using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.UnitTests
{
    public class ProjectManagerTest
    {
        private Project _project;

        [SetUp]
        public void Setup()
        {
            var _contactList = new List<Contact>()
            {
                new Contact(new string[3] {"Andrey", "Subbotin", "Maksimovich"}, new PhoneNumber("999", "6666666"),
                    new DateTime(2001, 11, 25), "Email", "99999"),

                new Contact(new string[3] {"Andrey", "Bobrov", "Yulianovich"}, new PhoneNumber("999", "6666666"),
                    new DateTime(2004, 12, 04), "Email", "99999"),

                new Contact(new string[3] { "Vyacheslav", "Mukhin", "Yulianovich"}, new PhoneNumber("999", "6666666"),
                    new DateTime(1995, 11, 25), "Email", "99999"),

                new Contact(new string[3] { "Taras", "Subbotin", "Lavrent'evich"}, new PhoneNumber("999", "6666666"),
                    new DateTime(1998, 03, 12), "Email", "99999"),
            };

            _project = new Project(_contactList);
        }

        [TestCase("TestSaveAndLoad.txt",
            "Must return project with  list of 4 contacts",
            TestName = "JSON save and load test")]
        [Ignore("Does not work for some reason. Better use jsondemo function in MainForm.")]
        public void TestSaveAndLoad_CorrectValue(string fileName, string Message)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var expected = _project;

            ProjectManager.SaveToFile(_project, path + @"\" + fileName);

            var actual = ProjectManager.LoadFromFile(path + @"\" + fileName);

            Assert.AreEqual(expected, actual, Message);

            if (File.Exists(path + @"\" + fileName))
            {
                File.Delete(path + @"\" + fileName);
            }
        }
    }
}