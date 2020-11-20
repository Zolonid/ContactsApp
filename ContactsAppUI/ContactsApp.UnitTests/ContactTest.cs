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

        [TestCase("9999999999",
            "Must match expected value",
            TestName = "Asserting correct Name in Name field")]
        public void TestNameSetGet_CorrectValue(string excpected, string Message)
        {
            var expected = new string[3] {"Name", "Middlename", "Lastname"};

            _contact.Name = expected;
            var actual = _contact.Name;
            Assert.AreEqual(expected, actual, "Name setter/getter exception.");
        }

        [TestCase("9999999999",
            "Must match expected value",
            TestName = "Asserting correct PhoneNumber in PhoneNumber field")]
        public void TestPhoneNumberSetGet_CorrectValue(string expected, string Message)
        {
            var expectedPN = new PhoneNumber(expected.Substring(0,3), expected.Substring(3, 7));

            _contact.PhoneNumber= expectedPN;
            var actual = _contact.PhoneNumber;
            Assert.AreEqual(expectedPN, actual, "PhoneNumber setter/getter exception.");
        }

        [TestCase("Jan 1, 2000",
            "Must match expected value",
            TestName = "Asserting correct DateTime in Birthday")]
        public void TestBirthDaySetGet_CorrectValue(string expected, string Message)
        {
            var expectedDT = DateTime.Parse(expected);

            _contact.Birthday = expectedDT;
            var actual = _contact.Birthday;
            Assert.AreEqual(expectedDT, actual, "Birthday setter/getter exception.");
        }

        [TestCase("GenericEmail@sobaka.com",
            "Must match expected value",
            TestName = "Asserting correct string in Email")]
        public void TestEmailSetGet_CorrectValue(string expected, string Message)
        {
            _contact.Email = expected;
            var actual = _contact.Email;
            Assert.AreEqual(expected, actual, "Email setter/getter exception.");
        }

        [TestCase("999999",
            "Must match expected value",
            TestName = "Asserting correct string in VKID")]
        public void TestVKIDSetGet_CorrectValue(string expected, string Message)
        {
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

        [TestCase(null,
            "Must be ArgumentNullException",
            TestName = "Asserting null array")]
        public void TestNameSet_ArgumentNullException(string[] wrongName, string Message)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                _contact.Name = wrongName;
            }, Message);
        }

        [TestCase(null,
            "Must be ArgumentNullException",
            TestName = "Asserting null PhoneNumber")]
        public void TestPhoneNumberSet_ArgumentNullException(PhoneNumber wrongPhoneNumber, string Message)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                _contact.PhoneNumber = wrongPhoneNumber;
            },
                Message);
        }

        [TestCase("Jan 1, 1800",
            "Must be ArgumentException",
            TestName = "Asserting date before 19th century")]

        [TestCase("Jan 1, 2100",
            "Must be ArgumentException",
            TestName = "Asserting date after 21st century")]
        public void TestBirthdaySet_ArgumentException(string wrongBirthdaySTR, string Message)
        {
            var wrongBirthday = DateTime.Parse(wrongBirthdaySTR);
            Assert.Throws<ArgumentException>(() =>
                {
                    _contact.Birthday = wrongBirthday;
                },
                Message);
        }

        [TestCase("ThisiIsVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryLongEmail@koshka.kz",
            "Must be ArgumentException",
            TestName = "Exceeding the limit in email")]
        public void TestEmailSet_ArgumentException(string wrongEmail, string Message)
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    _contact.Email = wrongEmail;
                },
                Message);
        }

        [TestCase("VeryVeryVeryVeryVeryLongVKID", 
            "Must be ArgumentException", 
            TestName = "Exceeding the limit in VKID")]
        public void TestVKIDSet_ArgumentException(string wrongVKID, string Message)
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    _contact.VKID = wrongVKID;
                },
                Message);
        }

        [TestCase(new string[3] {"AaAaAaAa", "BbBbBbBb", "CcCcCcCc"}, 
            new string[3] { "Aaaaaaaa", "Bbbbbbbb", "Cccccccc" }, 
            "Must correct value to format Aaaaa",
            TestName = "Testing convertion to lowercase.")]
        public void TestNameSet_ArgumentException(string[] wrongName, string[] excpectedName,string Message)
        {
            _contact.Name = wrongName;
            Assert.AreEqual(excpectedName,_contact.Name);
        }
    }
}