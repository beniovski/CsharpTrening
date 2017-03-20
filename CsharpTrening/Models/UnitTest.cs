using NUnit.Framework;
using System;

namespace CsharpTrening.Models
{
    [TestFixture]
    public class UnitTest
    {
        public User User;

        [SetUp]
        public void Setup()
        {
             User = new User("test@email.pl", "password");
        }
        [Test]
        public void changing_email_succes()
        {
           string TestEmail = "innmail";
            User.SetEmail(TestEmail);
            Assert.AreEqual(User.Email,TestEmail);
        }

        [Test]
        public void Empty_Password_Fail()
        {
          
            var expection = Assert.Throws<Exception>(() => User.SetPassword(String.Empty));
            Assert.NotNull(expection);
            Assert.IsTrue(expection.Message.Equals("Password is incorect"));
        }

        [Test]
        public void Database_Test()
        {
            
        }


    }
}