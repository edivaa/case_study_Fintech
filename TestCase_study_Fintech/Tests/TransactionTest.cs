using Case_study_Fintech.Models;
using Case_study_Fintech.Services.Implementations;
using NUnit.Framework;
using System;

namespace TestCase_study_Fintech
{
    [Category("NUnit")]
    public class TransactionTest
    {
        private TransactionService transactionService;


        [SetUp]
        public void Setup()
        {
            transactionService = new TransactionService();
        }



        [Test]
        public void ShouldTransferWithBalance()
        {
            //arrange
            var accountNumber = 12556;
            var value = 2001;

            //act
            var withdrawalValue = transactionService.TransferByPix(accountNumber, value);

            //Assert 
            Assert.IsTrue(withdrawalValue > 0);
        }

        [Test]
        public void ShouldReturnErrorWithoutBalance()
        {
            //arrange
            var accountNumber = 58996;
            var value = 2001;


            //assert 
            Assert.That(() => transactionService.TransferByPix(accountNumber, value),
             Throws.TypeOf<Exception>()
             .With.Matches<Exception>(mess => mess.Message == "Conta sem saldo"));

        }

        [Test]
        public void ShouldReturnErrorBalanceLessThanTransferAmount()
        {
            //arrange Balance =1000000
            var accountNumber = 12556;
            var value = 1100000;

            //Act //assert 
            Assert.That(() => transactionService.TransferByPix(accountNumber, value),
                Throws.TypeOf<Exception>()
                .With.Matches<Exception>(mess => mess.Message == "valor acima do saldo"));

        }

        [Test]
        public void ShouldRetornErrorMinimumAmountAllowedForTransfer()
        {

            //arrange
            var accountNumber = 12556;
            var value = 1999;


            //assert 
            Assert.That(() => transactionService.TransferByPix(accountNumber, value),
             Throws.TypeOf<Exception>()
             .With.Matches<Exception>(mess => mess.Message == "Valor minimo igual ou acima de 2000"));

        }


        [Test]
        public void ShouldRetornErrorAccountDoesNotExist()
        {

            //arrange
            var accountNumber = 889995;
            var value = 2005;


            //assert 
            Assert.That(() => transactionService.TransferByPix(accountNumber, value),
             Throws.TypeOf<Exception>()
             .With.Matches<Exception>(mess => mess.Message == "A conta n?o existe"));

        }


        [Test]
        public void ShouldReturnTransferHistory()
        {

            //arrange
            var accountNumber = 12556;

            //act
            var history = transactionService.TransferHistory(accountNumber);

            //assert 
            Assert.That(history, Is.Not.Empty);

        }


    }
}