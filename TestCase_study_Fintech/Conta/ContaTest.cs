using Case_study_Fintech.Models;
using Case_study_Fintech.Services;
using NUnit.Framework;

namespace TestCase_study_Fintech
{
    public class Tests
    {
        private ContaService contaService;  

        [SetUp]
        public void Setup()
        {
            contaService = new ContaService();
        }


        [Test]
        public void ObterContas()
        {
            //arrange

            //act
            var contas = contaService.GetContas();

            //Assert 
            Assert.IsNotNull(contas);
        }

        [Test]
        public void ObterConta()
        {
            //arrange
            var numConta = 12556; 

            //act
            var conta = contaService.GetConta(numConta);

            //Assert 
            Assert.AreEqual(numConta, conta.NumConta);
        }

        [Test]
        public void CriarConta()
        {
            //arrange
            var conta = new Conta() { Nome = "Paulo Santos", Email="paulo@gmail.com", NumConta=12556, Saldo =0 }; 

            //act
            var newConta = contaService.CreateConta(conta);

            //Assert 
            Assert.AreEqual(newConta.Nome, conta.Nome);
            Assert.AreEqual(newConta.Email, conta.Email);
        }

        [Test]
        public void CriarContaFalha()
        {
            //arrange
            var conta = new Conta() { Nome = "Paulo Santos", Email="paulo@gmail.com", NumConta=0, Saldo =0 }; 

            //act
            var newConta = contaService.CreateConta(conta);

            //Assert 
            Assert.AreEqual(newConta.Nome, conta.Nome);
            
        }
    }
}