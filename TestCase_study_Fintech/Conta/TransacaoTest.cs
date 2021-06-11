using Case_study_Fintech.Models;
using Case_study_Fintech.Services;
using NUnit.Framework;

namespace TestCase_study_Fintech
{
    public class TransacaoTests
    {
        private TransacaoService transacaoService;  
        private ContaService contaService;  

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
            var valor = 2001;

            //act
            var valorSaque = transacaoService.SacarPix(numConta, valor);

            //Assert 
            Assert.IsTrue( valorSaque > 0);
        }

         [Test]
        public void TransacaoSaqueSemSaldo()
        {
            //arrange
            var conta = new Conta() { Nome = "Robson", Email="robson@gmail.com", NumConta=0, Saldo =0 };  
            var valor = 2001;


            try{

                //act
                var newConta = contaService.CreateConta(conta);  
                var valorSaque = transacaoService.SacarPix(newConta.NumConta, valor);
            }
            catch (System.Exception ex)
            {

               //Assert 
               Assert.Equals("Conta sem saldo", ex.Message);

            }

        }

       
    }
}