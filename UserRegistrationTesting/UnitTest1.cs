using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationProblem;

namespace UserRegistrationTestings
{
    [TestClass]
    public class UnitTest1
    {
        //Happy Test Cases(Test Cases Pass The Entries)
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            UserRegistrationValidation user = new UserRegistrationValidation();
            string firstName = "Snehil";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            UserRegistrationValidation user = new UserRegistrationValidation();
            string lastName = "Verma";
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            UserRegistrationValidation user = new UserRegistrationValidation();
            string email = "SnehilSingh4888@gmail.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            UserRegistrationValidation user = new UserRegistrationValidation();
            string mobileNumber = "91 9876543210";
            //Act
            bool result = user.ValidateMobileNumber(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            UserRegistrationValidation user = new UserRegistrationValidation();
            string password = "Snehil@543";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        //Sad Test Cases(Test Cases Fail The Entry)
        [TestMethod]
        public void GivenUserFistName_WhenValidate_Should_Throw_InvalidUserDetailException_Indicating_Invalid_FirstName()
        {
            try
            {
                //Arrange
                UserRegistrationValidation user = new UserRegistrationValidation();
                string firstName = "snehil";
                //Act
                bool result = user.ValidateFirstName(firstName);
            }
            catch (InvalidUserDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid first name.", e.Message);
            }
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_Should_Throw_InvalidUserDetailException_Indicating_Invalid_LastName()
        {
            try
            {
                //Arrange
                UserRegistrationValidation user = new UserRegistrationValidation();
                string lastName = "verma";
                //Act
                bool result = user.ValidateLastName(lastName);
            }
            catch (InvalidUserDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid last name.", e.Message);
            }
        }
        [TestMethod]
        public void GivenEmail_WhenValidate_Should_Throw_InvalidUserDetailException_Indicating_Invalid_Email()
        {
            try
            {
                //Arrange
                UserRegistrationValidation user = new UserRegistrationValidation();
                string email = "SnehilSinghgmail.com";
                //Act
                bool result = user.ValidateEmail(email);
            }
            catch (InvalidUserDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid email id.", e.Message);
            }
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_Should_Throw_InvalidUserDetailException_Indicating_Invalid_MobileNumber()
        {
            try
            {
                //Arrange
                UserRegistrationValidation user = new UserRegistrationValidation();
                string mobileNumber = "91 0876543210";
                //Act
                bool result = user.ValidateMobileNumber(mobileNumber);
            }
            catch (InvalidUserDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid mobile number.", e.Message);
            }
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_Should_Throw_InvalidUserDetailException_Indicating_Invalid_Password()
        {
            try
            {
                //Arrange
                UserRegistrationValidation user = new UserRegistrationValidation();
                string password = "snehil@#543";
                //Act
                bool result = user.ValidatePassword(password);
            }
            catch (InvalidUserDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid password.", e.Message);
            }
        }
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenEmailIds_WhenValidate_ShouldReturnTrue(string email)
        {
            //Arrange
            UserRegistrationValidation user = new UserRegistrationValidation();
            //Act
            bool result = user.ValidateEmail2(email);
            //Assert
            Assert.IsTrue(result);
        }
    }
}
