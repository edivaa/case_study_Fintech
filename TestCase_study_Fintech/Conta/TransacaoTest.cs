using Case_study_Fintech.Models;
using Case_study_Fintech.Services;
using NUnit.Framework;
using System;

namespace TestCase_study_Fintech
{
    [Category("NUnit")]
    public class TransacaoTests
    {
        private TransactionService transacaoService;  
        private AccountService contaService;  

        [SetUp]
        public void Setup()
        {
            transacaoService = new TransactionService();
            contaService = new AccountService();
        }


        
        [Test]
        public void TransacaoSaqueComSaldo()
        {
            //arrange
            var numConta = 12556; 
            var valor = 2001;

            //act
            var valorSaque = transacaoService.SacarPix(numConta, valor);

            //Assert 
            Assert.IsTrue( valorSaque > 0);
        }

         [Test]
        public void TransacaoSaqueSemSaldoFalha()
        {
             //arrange
             var numConta = 58996;
             var valor = 2001;
      
             //assert 
             Assert.Throws<Exception>(()=> transacaoService.SacarPix(numConta , valor));
        
        }

       
    }
}