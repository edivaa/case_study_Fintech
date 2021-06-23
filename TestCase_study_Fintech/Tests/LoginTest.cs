using Case_study_Fintech.Models;
using Case_study_Fintech.Services.Implementations;
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
            var login = new User() { Name = "paulo", Email = "paulo@gmail.com", Password = "25636" };
            //act
            var newLogin = userService.Authentication(login);

            //Assert 
            Assert.That(newLogin.Name, Is.EqualTo(login.Name));
        }

        [Test]
        public void ShouldMustNotAuthenticateInvalidUserOrPassword()
        {
            //arrange
            var user = new User() { Name = "adriano", Email="adriano@gmail.com", Password = "25636" };


            //act //assert 
            Assert.That(() => userService.Authentication(user),
             Throws.TypeOf<Exception>()
             .With.Matches<Exception>(mess => mess.Message == "Usu�rio n�o existe"));
        }
    }
}