using Case_study_Fintech.Models;
using Case_study_Fintech.Services;
using NUnit.Framework;
using System;

namespace TestCase_study_Fintech
{
    [Category("NUnit")]
    public class LoginTest
    {
         private LoginService loginService;  

        [SetUp]
        public void Setup()
        {
             loginService = new LoginService();
        }


        [Test]
        public void ShouldAuthenticateWithValidUser()
        {
            //arrange
            var login = new Login() { UserName = "paulo", Password = "25636" };
            //act
            var newLogin = loginService.GetAuthentication(login);

            //Assert 
            Assert.That(newLogin.UserName, Is.EqualTo(login.UserName));
        }
    }
}