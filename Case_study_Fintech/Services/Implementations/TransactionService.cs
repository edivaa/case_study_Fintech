using Case_study_Fintech.Models;
using Case_study_Fintech.Repositories.Implementations;
using System;
using System.Collections.Generic;


namespace Case_study_Fintech.Services.Implementations
{
    public class TransactionService : ITransactionService
    {
        readonly IAccountService AccountService;
        readonly TransactionRepository transactionRepository;

        public TransactionService(IAccountService accountService)
        {
            AccountService = accountService;
            transactionRepository = new TransactionRepository();
        }
     
        public Decimal TransferByPix(int? accountNumber, decimal value) {

            var account = AccountService.GetAccount(accountNumber);

             ValidateAccount(account);
             ValidateAccountBalance(account, value);
             ValidateMinimumAmountAllowedWithdrawal(value);

            transactionRepository.AddTrasaction(new AccountTransaction() { AccountNumber = accountNumber, TransactionDate = DateTime.Now, TransactionType = "T" });

            return account.Balance - value;
        }

        public List<AccountTransaction> TransferHistory(int accountNumber)
        {
            return transactionRepository.GetTransactions(accountNumber);
        }


        private void ValidateAccountBalance(Account account, decimal value)
        {
            if (!account.HasBalance())
            {
                throw new Exception("Conta sem saldo");
            }

            if (!account.hasBalanceForValue(value))
            {
                throw new Exception("valor acima do saldo");
            }
        }


        private void ValidateMinimumAmountAllowedWithdrawal(decimal value)
        {
            if (value < 2000)
            {
                throw new Exception("Valor minimo igual ou acima de 2000");
            }
        }

        private void ValidateAccount(Account account)
        {
            if (account == null)
            {
                throw new Exception("A conta não existe");
            }
        }

        
    }
}
