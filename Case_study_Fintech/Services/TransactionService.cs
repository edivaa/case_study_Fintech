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
    
        public Decimal WithdrawMoneyByPix(int? accountNumber, decimal value) {

               var account = accountService.GetAccount(accountNumber);
                if(!account.HasBalance()) {
                    throw new Exception("Conta sem saldo");
                } 

               return account.Balance-value;
        }
    }
}
