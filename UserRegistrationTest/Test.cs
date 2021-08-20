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
            bool expected = true;
            bool actual = User.ValidateFirstName();
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenFirstNameValid_ShouldReturnSad()
        {
            bool expected = false;
            bool actual = User.ValidateFirstName();
            Assert.AreNotEqual(actual, expected);
        }
        [Test]
        public void GivenLastNameValid_ShouldReturnHappy()
        {
            bool expected = true;
            bool actual = User.ValidateLastName();
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenLastNameInvalid_ShouldReturnSad()
        {
            bool expected = false;
            bool actual = User.ValidateLastName();
            Assert.AreNotEqual(actual, expected);
        }
        [Test]
        public void GivenEmailValid_ShouldReturnHappy()
        {
            bool expected = true;
            bool actual = User.ValidateEmail();
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenEmailInvalid_ShouldReturnSad()
        {
            bool expected = false;
            bool actual = User.ValidateEmail();
            Assert.AreNotEqual(actual, expected);
        }
        [Test]
        public void GivenMobileValid_ShouldReturnHappy()
        {
            bool expected = true;
            bool actual = User.ValidatePhone();
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenMobileInvalid_ShouldReturnSad()
        {
            bool expected = false;
            bool actual = User.ValidatePhone();
            Assert.AreNotEqual(actual, expected);
        }
        [Test]
        public void GivenPasswordValid_ShouldReturnHappy()
        {
            bool expected = true;
            bool actual = User.PasswordR1();
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenPasswordInvalid_ShouldReturnSad()
        {
            bool expected = false;
            bool actual = User.PasswordR1();
            Assert.AreNotEqual(actual, expected);
        }
    }
}