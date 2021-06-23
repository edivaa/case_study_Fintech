using Case_study_Fintech.Models;
using Case_study_Fintech.Repositories;
using Case_study_Fintech.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Services.Implementations
{
    public class AccountService : IAccountService
    {
        readonly IAccountRepository AccountRepository;
         private Random random = new Random();
        public AccountService(IAccountRepository accountRepository)
        {
            AccountRepository = accountRepository;
        }
        public List<Account> GetAccounts()
        {
            return AccountRepository.GetAccounts();
        }
        public Account GetAccount(int? id)
        {
            return AccountRepository.GetAccount(id);
        }
        public Account CreateAnAccount(Account account) {

               var thereIsAnAccount = AccountRepository.GetAccount(account.AccountNumber);
               if(thereIsAnAccount != null) {
                   throw new Exception("Conta ja existe");
               }else {
                   account.AccountNumber = random.Next(0, 10000);
                   AccountRepository.AddAccount(account);
               }

               return account;
        }


        public decimal GetBalance(int accountNumber)
        {
            return AccountRepository.GetBalance(accountNumber);
        }
    }
}
