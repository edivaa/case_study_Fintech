using Case_study_Fintech.Models;
using Case_study_Fintech.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Services
{
    public class AccountService
    {
        readonly AccountRepository accountRepository;
         private Random random = new Random();
        public AccountService()
        {
            accountRepository = new AccountRepository();
        }
        public List<Account> GetAccounts()
        {
            return accountRepository.GetAccounts();
        }
        public Account GetAccount(int? id)
        {
            return accountRepository.GetAccount(id);
        }
        public Account CreateAnAccount(Account account) {

               var thereIsAnAccount = accountRepository.GetAccount(account.AccountNumber);
               if(thereIsAnAccount != null) {
                   throw new Exception("Conta ja existe");
               }else {
                   account.AccountNumber = random.Next(0, 10000);
                   accountRepository.AddAccount(account);
               }

               return account;
        }


        public decimal GetBalance(int accountNumber)
        {
            return accountRepository.GetBalance(accountNumber);
        }
    }
}
