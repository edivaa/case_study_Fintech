using Case_study_Fintech.Models;
using Case_study_Fintech.Services;
using NUnit.Framework;
using System;

namespace TestCase_study_Fintech
{
    [Category("NUnit")]
    public class AccountTest
    {
        private AccountService accountService;  

        [SetUp]
        public void Setup()
        {
            accountService = new AccountService();
        }


        [Test]
        public void ShouldGetAccounts()
        {
            //arrange

            //act
            var accounts = accountService.GetAccounts();

            //Assert 
            Assert.IsNotNull(accounts);
        }

        [Test]
        public void ShouldGetAccount()
        {
            //arrange
            var accountNumber = 12556; 

            //act
            var account = accountService.GetAccount(accountNumber);

            //Assert 
            Assert.AreEqual(accountNumber, account.AccountNumber);
        }

        [Test]
        public void shouldCreateAnAccountg()
        {
            //arrange
            var account = new Account() { Name = "Paulo Santos", Email="paulo@gmail.com", AccountNumber=0, Balance =0 }; 

            //act
            var newAccount = accountService.CreateAnAccount(account);

            //Assert 
            Assert.AreEqual(newAccount.Name, account.Name);
            Assert.AreEqual(newAccount.Email, account.Email);
            Assert.That(newAccount.AccountNumber, Is.EqualTo(account.AccountNumber));
        }



        [Test, Description("Conta conta falha")]
        //[TestCase(new Conta() { Nome = "Paulo Santos", Email = "paulo@gmail.com", NumConta = 32897, Saldo = 0 }) ]
        public void NotShouldCreateAnAccount()
        {
            //arrange
            var account = new Account() { Name = "Paulo Santos", Email = "paulo@gmail.com", AccountNumber = 32897, Balance = 0 };

            //act //assert 
            Assert.Throws<Exception>(() => accountService.CreateAnAccount(account));
        }
    
    }
}