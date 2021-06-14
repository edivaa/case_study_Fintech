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
         private Random random = new Random();
        public TransactionService()
        {
            accountService = new AccountService();
        }
        public List<Account> GetAccounts()
        {
            return accountService.GetAccounts();
        }
    
        public Decimal SacarPix(int? accountNumber, decimal value) {

               var conta = accountService.GetAccount(accountNumber);
                if(!conta.HasBalance()) {
                    throw new Exception("Conta sem saldo");
                } 

               return conta.Balance-value;
        }
    }
}
