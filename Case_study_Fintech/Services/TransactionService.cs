using Case_study_Fintech.Models;
using Case_study_Fintech.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Services
{
    public class TransactionService
    {
        readonly AccountService accountService;

        public TransactionService()
        {
            accountService = new AccountService();
        }
        public List<Account> GetAccounts()
        {
            return accountService.GetAccounts();
        }

        public Decimal TransferByPix(int? accountNumber, decimal value) {

            var account = accountService.GetAccount(accountNumber);
          
            ValidateAccountBalance(account, value);
            ValidateMinimumAmountAllowedWithdrawal(value);

            return account.Balance - value;
        }

        public void ValidateAccountBalance(Account account, decimal value)
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


        public void ValidateMinimumAmountAllowedWithdrawal(decimal value)
        {
            if (value < 2000)
            {
                throw new Exception("Valor minimo igual ou acima de 2000");
            }
        }

        public List<string> TransferHistory(int accountNumber)
        {
            throw new NotImplementedException();
        }
    }
}
