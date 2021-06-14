using Case_study_Fintech.Models;
using Case_study_Fintech.Services;
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
        public void ShouldWithdrawWithBalance()
        {
            //arrange
            var accountNumber = 12556; 
            var value = 2001;

            //act
            var withdrawalValue = transactionService.WithdrawMoneyByPix(accountNumber, value);

            //Assert 
            Assert.IsTrue( withdrawalValue > 0);
        }

         [Test]
        public void ShouldReturnErrorWithoutBalance()
        {
             //arrange
             var accountNumber = 58996;
             var value = 2001;
      
             //assert 
             Assert.Throws<Exception>(()=> transactionService.WithdrawMoneyByPix(accountNumber , value));
        
        }

       
    }
}