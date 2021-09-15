using System;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.UnitTests
{
    class PhoneNumberTest
    {
        private PhoneNumber _phoneNumber;

        [SetUp]
        public void Setup()
        {
            _phoneNumber = new PhoneNumber();
        }

        [TestCase("999",
            "Must matchd expected value",
            TestName = "Asserting correct string in ZoneCode")]
        public void TestZoneCodeSetGet_CorrectValue(string expected, string Message)
        {
            _phoneNumber.ZoneCode = expected;
            var actual = _phoneNumber.ZoneCode;
            Assert.AreEqual(expected, actual, "ZoneCode setter/getter exception.");
        }

        [TestCase("9999999",
            "Must matchd expected value",
            TestName = "Asserting correct string in Number")]
        public void TestNumberSetGet_CorrectValue(string expected, string Message)
        {
            _phoneNumber.Number = expected;
            var actual = _phoneNumber.Number;
            Assert.AreEqual(expected, actual, "Number setter/getter exception.");
        }

        [TestCase("",
            "Must be ArgumentException",
            TestName = "Asserting empty string in Number")]

        [TestCase("9999999999",
            "Must be ArgumentException",
            TestName = "Exceeding character limit in Number")]
        public void TestNumberSet_ArgumentException(string wrongNumber, string Message)
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    _phoneNumber.Number = wrongNumber;
                },
                Message);
        }

        [TestCase("",
            "Must be ArgumentException",
            TestName = "Asserting empty string in ZoneCode")]

        [TestCase("9999999999",
            "Must be ArgumentException",
            TestName = "Exceeding character limit in ZoneCode")]
        public void TestZoneCodeSet_ArgumentException(string wrongZoneCode, string Message)
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    _phoneNumber.ZoneCode = wrongZoneCode;
                },
                Message);
        }
    }
}
