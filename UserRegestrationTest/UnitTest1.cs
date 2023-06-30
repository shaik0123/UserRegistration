using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using UserRegisteration;

namespace UserRegestrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckFirstName()
        {
            string e = "Ismail";
            User u = new User();
            string actual = u.FirstName(e);
            Assert.AreEqual(e, actual);
        }
        [TestMethod]
        public void CheckLastName() 
        {
            string LastName = "Shaik";
            User u = new User();
            string actual = u.LastName(LastName);
            Assert.AreEqual(LastName, actual);
        }
        [TestMethod]
        public void CheckEmail()
        {
            string Email = "shaik.ismail@gmail.com.in";
            User u = new User();
            string actual = u.Email(Email);
            Assert.AreEqual(Email, actual);
        }
        [TestMethod]
        public void CheckMobileNumber()
        {
            string MobileNumber = "91 9988776655";
            User u = new User();
            string actual = u.MobileNumber(MobileNumber);
            Assert.AreEqual(MobileNumber, actual);
        }
        [TestMethod]
        public void CheckPasswordRule1()
        {
            string Password = "asdfghjk";
            User u = new User();
            string actual = u.PasswordRule1(Password);
            Assert.AreEqual(Password, actual);
        }
        [TestMethod]
        public void CheckPasswordRule2()
        {
            string Password = "Asdfghjk";
            User u = new User();
            string actual = u.PasswordRule2(Password);
            Assert.AreEqual(Password, actual);
        }
        [TestMethod]
        public void CheckPasswordRule3()
        {
            string Password = "Ashsj1234";
            User u = new User();
            string actual = u.PasswordRule3(Password);
            Assert.AreEqual(Password, actual);
        }
        [TestMethod]
        public void CheckPasswordRule4()
        {
            string Password = "Asha@1234";
            User u = new User();
            string actual = u.PasswordRule4(Password);
            Assert.AreEqual(Password, actual);
        }


    }
}
