using Case_study_Fintech.Models;
using Case_study_Fintech.Services;
using NUnit.Framework;
using System;

namespace TestCase_study_Fintech
{
    [Category("NUnit")]
    public class TestsConta
    {
        private AccountService contaService;  

        [SetUp]
        public void Setup()
        {
            contaService = new AccountService();
        }


        [Test]
        public void ObterContas()
        {
            //arrange

            //act
            var contas = contaService.GetAccounts();

            //Assert 
            Assert.IsNotNull(contas);
        }

        [Test]
        public void ObterConta()
        {
            //arrange
            var numConta = 12556; 

            //act
            var conta = contaService.GetAccount(numConta);

            //Assert 
            Assert.AreEqual(numConta, conta.AccountNumber);
        }

        [Test]
        public void CriarConta()
        {
            //arrange
            var conta = new Account() { Name = "Paulo Santos", Email="paulo@gmail.com", AccountNumber=0, Balance =0 }; 

            //act
            var newConta = contaService.CreateAnAccount(conta);

            //Assert 
            Assert.AreEqual(newConta.Name, conta.Name);
            Assert.AreEqual(newConta.Email, conta.Email);
            Assert.That(newConta.AccountNumber, Is.EqualTo(conta.AccountNumber));
        }



        [Test, Description("Conta conta falha")]
        //[TestCase(new Conta() { Nome = "Paulo Santos", Email = "paulo@gmail.com", NumConta = 32897, Saldo = 0 }) ]
        public void CriarContaFalha()
        {
            //arrange
            var conta = new Account() { Name = "Paulo Santos", Email = "paulo@gmail.com", AccountNumber = 32897, Balance = 0 };

            //act //assert 
            Assert.Throws<Exception>(() => contaService.CreateAnAccount(conta));
        }
    
    }
}