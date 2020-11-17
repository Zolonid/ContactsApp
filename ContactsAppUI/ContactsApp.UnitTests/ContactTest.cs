using System;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.UnitTests
{
    public class ContactTest
    {
        private Contact _contact;

        [SetUp]
        public void Setup()
        {
            _contact = new Contact();
        }

        [Test]
        public void TestNameSetGet_CorrectValue()
        {
            var expected = new string[3] {"Name", "Middlename", "Lastname"};

            _contact.Name = expected;
            var actual = _contact.Name;
            Assert.AreEqual(expected, actual, "Name setter/getter exception.");
        }

        [Test(Description = "Asserting correct value to PhoneNumber")]
        public void TestPhoneNumberSetGet_CorrectValue()
        {
            var expected = new PhoneNumber("999","9999999");

            _contact.PhoneNumber= expected;
            var actual = _contact.PhoneNumber;
            Assert.AreEqual(expected, actual, "PhoneNumber setter/getter exception.");
        }

        [Test]
        public void TestBirthDaySetGet_CorrectValue()
        {
            var expected = new DateTime(2000, 4, 16);

            _contact.Birthday = expected;
            var actual = _contact.Birthday;
            Assert.AreEqual(expected, actual, "Birthday setter/getter exception.");
        }

        [Test]
        public void TestEmailSetGet_CorrectValue()
        {
            var expected = "GenericEmail@sobaka.com";

            _contact.Email = expected;
            var actual = _contact.Email;
            Assert.AreEqual(expected, actual, "Email setter/getter exception.");
        }

        [Test]
        public void TestVKIDSetGet_CorrectValue()
        {
            var expected = "999999";
            _contact.VKID = expected;
            var actual = _contact.VKID;
            Assert.AreEqual(expected, actual, "VKID setter/getter exception.");
        }

        [TestCase(new string[3] { "", "", "" },
            "Must be ArgumentException",
            TestName = "Asserting empty string in Name")]

        [TestCase(new string[3] {
                "Name-name-name-name-name-name-name-name-name-name-name-name-",
                "Middlename-middlename-middlename-middlename-middlename-middlename",
                "Lastname-lastname-lastname-lastname-lastname-lastname-lastname-lastname" },
            "Must be ArgumentException",
            TestName = "Exceeding character limit in Name")]

        public void TestNameSet_ArgumentException(string[] wrongName, string Message)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                _contact.Name = wrongName;
            }, Message);
        }

        [TestCase(null, "Must be ArgumentNullException", TestName = "Asserting null array")]
        public void TestNameSet_ArgumentNullException(string[] wrongName, string Message)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                _contact.Name = wrongName;
            }, Message);
        }

        [TestCase(null, "Must be ArgumentNullException", TestName = "Asserting null PhoneNumber")]
        public void TestPhoneNumberSet_ArgumentNullException(PhoneNumber wrongPhoneNumber, string Message)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                _contact.PhoneNumber = wrongPhoneNumber;
            },
                Message);
        }

        [TestCase("Jan 1, 1800", "Must be ArgumentException", TestName = "Asserting date before 19th century")]
        [TestCase("Jan 1, 2100", "Must be ArgumentException", TestName = "Asserting date after 21st century")]
        public void TestBirthdaySet_ArgumentException(string wrongBirthdaySTR, string Message)
        {
            var wrongBirthday = DateTime.Parse(wrongBirthdaySTR);
            Assert.Throws<ArgumentException>(() =>
                {
                    _contact.Birthday = wrongBirthday;
                },
                Message);
        }

        [TestCase("ThisiIsVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryLongEmail@koshka.kz", "Must be ArgumentException", TestName = "Exceeding the limit in email")]
        public void TestEmailSet_ArgumentException(string wrongEmail, string Message)
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    _contact.Email = wrongEmail;
                },
                Message);
        }

        [TestCase("VeryVeryVeryVeryVeryLongVKID", "Must be ArgumentException", TestName = "Exceeding the limit in VKID")]
        public void TestVKIDSet_ArgumentException(string wrongVKID, string Message)
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    _contact.VKID = wrongVKID;
                },
                Message);
        }
    }
}