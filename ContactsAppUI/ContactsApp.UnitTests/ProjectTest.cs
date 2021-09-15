using System;
using System.Collections.Generic;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.UnitTests
{
    public class ProjectTest
    {
        private Project _project;

        [SetUp]
        public void Setup()
        {
            var _contactList = new List<Contact>()
            {
                new Contact(new string[3] {"Andrey", "Maksimovich", "Subbotin"}, new PhoneNumber("999", "6666666"),
                    new DateTime(2001, 11, 25), "Email", "99999"),

                new Contact(new string[3] {"Andrey", "Anyulianovich", "Bobrov"}, new PhoneNumber("999", "6666666"),
                    new DateTime(2004, 12, 04), "Email", "99999"),

                new Contact(new string[3] {"Vyacheslav", "Anyulianovich", "Mukhin"}, new PhoneNumber("999", "6666666"),
                    new DateTime(1995, 11, 25), "Email", "99999"),

                new Contact(new string[3] {"Taras", "Lavrent'evich", "Subbotin"}, new PhoneNumber("999", "6666666"),
                    new DateTime(1998, 03, 12), "Email", "99999"),
            };

            _project = new Project(_contactList);
        }

        [TestCase("Andrey",
            "Must return 1 and 2 contact.",
            TestName = "Seacrhing \"Andrey\" in name.")]
        public void TestFindInName_CorrectValue(string searchString, string Message)
        {
            var expectedList = new List<Contact>();

            expectedList.Add(_project.ContactList[0]);
            expectedList.Add(_project.ContactList[1]);

            var actualList = _project.FindInName(searchString);

            Assert.AreEqual(expectedList, actualList, Message);
        }

        [TestCase("Anyulianovich",
            "Must return 1 and 2 contact.",
            TestName = "Seacrhing \"Anyulianovich\" in middle name.")]
        public void TestFindInMiddleName_CorrectValue(string searchString, string Message)
        {
            var expectedList = new List<Contact>();

            expectedList.Add(_project.ContactList[1]);
            expectedList.Add(_project.ContactList[2]);

            var actualList = _project.FindInMiddleName(searchString);

            Assert.AreEqual(expectedList, actualList, Message);
        }

        [TestCase("Subbotin",
            "Must return 1 and 4 contact.",
            TestName = "Seacrhing \"Subbotin\" in middle name.")]
        public void TestFindInLastName_CorrectValue(string searchString, string Message)
        {
            var expectedList = new List<Contact>();

            expectedList.Add(_project.ContactList[0]);
            expectedList.Add(_project.ContactList[3]);

            var actualList = _project.FindInLastName(searchString);

            Assert.AreEqual(expectedList, actualList, Message);
        }

        [TestCase("An",
            "Must return 1, 2 and 3 contact.",
            TestName = "Seacrhing \"An\" in full name.")]
        public void TestFindInFullName_CorrectValue(string searchString, string Message)
        {
            var expectedList = new List<Contact>();

            expectedList.Add(_project.ContactList[0]);
            expectedList.Add(_project.ContactList[1]);
            expectedList.Add(_project.ContactList[2]);

            var actualList = _project.FindInFullName(searchString);

            Assert.AreEqual(expectedList, actualList, Message);
        }
    }
}