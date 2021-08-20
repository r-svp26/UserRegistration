using NUnit.Framework;
using UserRegistration;

namespace UserRegistrationTest
{
    public class Test
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void GivenFirstNameValid_ShouldReturnHappy()
        {
            string expected = "true";
            string actual = User.ValidateFirstName("Ritesh");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenFirstNameValid_ShouldReturnSad()
        {
            string expected = "false";
            string actual = User.ValidateFirstName("2itesh");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenLastNameValid_ShouldReturnHappy()
        {
            string expected = "true";
            string actual = User.ValidateLastName("Kumar");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenLastNameInvalid_ShouldReturnSad()
        {
            string expected = "false";
            string actual = User.ValidateLastName("kUmar");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenEmailValid_ShouldReturnHappy()
        {
            string expected = "true";
            string actual = User.ValidateEmail("abc-100@yahoo.com");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenEmailInvalid_ShouldReturnSad()
        {
            string expected = "false";
            string actual = User.ValidateEmail("rit_10@ya@gmail.com");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenMobileValid_ShouldReturnHappy()
        {
            string expected = "true";
            string actual = User.ValidatePhone("91 9907296689");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenMobileInvalid_ShouldReturnSad()
        {
            string expected = "false";
            string actual = User.ValidatePhone("100");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenPasswordValid_ShouldReturnHappy()
        {
            string expected = "true";
            string actual = User.ValidatePassword("Rit@6341");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenPasswordInvalid_ShouldReturnSad()
        {
            string expected = "false";
            string actual = User.ValidatePassword("91 88012");
            Assert.AreEqual(actual, expected);
        }
    }
}