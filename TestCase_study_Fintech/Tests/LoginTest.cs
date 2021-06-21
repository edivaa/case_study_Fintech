using Case_study_Fintech.Models;
using Case_study_Fintech.Services;
using NUnit.Framework;
using System;

namespace TestCase_study_Fintech
{
    [Category("NUnit")]
    public class LoginTest
    {
         private UserService userService;  

        [SetUp]
        public void Setup()
        {
             userService = new UserService();
        }


        [Test]
        public void ShouldAuthenticateWithValidUser()
        {
            //arrange
            var login = new User() { UserName = "paulo", Password = "25636" };
            //act
            var newLogin = userService.Authentication(login);

            //Assert 
            Assert.That(newLogin.UserName, Is.EqualTo(login.UserName));
        }

        [Test]
        public void ShouldMustNotAuthenticateInvalidUserOrPassword()
        {
            //arrange
            var user = new User() { UserName = "adriano", Password = "25636" };


            //act //assert 
            Assert.That(() => userService.Authentication(user),
             Throws.TypeOf<Exception>()
             .With.Matches<Exception>(mess => mess.Message == "Usuário não existe"));
        }
    }
}