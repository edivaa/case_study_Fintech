using Case_study_Fintech.Models;
using Case_study_Fintech.Services;
using NUnit.Framework;

namespace TestCase_study_Fintech
{
    public class TransacaoTests
    {
        private TransacaoService transacaoService;  

        [SetUp]
        public void Setup()
        {
            transacaoService = new TransacaoService();
        }


        
        [Test]
        public void TransacaoSaqueComSaldo()
        {
            //arrange
            var numConta = 12556; 

            //act
            var valorSaque = transacaoService.SacarPix(numConta);

            //Assert 
            Assert.IsTrue( valorSaque > 0);
        }

       
    }
}