using Case_study_Fintech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Repositories
{
    public class AccountRepository
    {
        private List<Account> accounts;

        public AccountRepository()
        {
          accounts  = new List<Account>() {
                new Account() { User = new  User() { Name = "Antonio", LastName = "Santos", Email = "antonio@gmail.com" }, AccountNumber = 12556, Balance =1000000 },
                new Account() { User = new  User() { Name = "Aiton", LastName = "Rosa", Email = "aiton@gmail.com" }, AccountNumber = 32897, Balance =4000000 },
                new Account() { User = new  User() { Name = "Tamara", LastName = "Pitanga", Email = "tamara@gmail.com" }, AccountNumber = 45896, Balance =9000000 },
                new Account() { User = new  User() { Name = "Robson", LastName = "Santana", Email="robson@gmail.com"}, AccountNumber=58996, Balance =0 }
        };
        }

        public List<Account> GetAccounts()
        {
            return accounts;
        }

        public Account GetAccount(int? numConta)
        {
            return accounts.FirstOrDefault(c=>c.AccountNumber == numConta);
        }

        public Decimal GetBalance(int? numConta)
        {
            return accounts.Where(c => c.AccountNumber == numConta).Select(c => c.Balance).FirstOrDefault();
        }


        public Account AddAccount(Account account) {
            accounts.Add(account);

            return GetAccount(account.AccountNumber);
        }

    }
}
