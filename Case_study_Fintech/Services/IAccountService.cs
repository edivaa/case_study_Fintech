using Case_study_Fintech.Models;
using System.Collections.Generic;

namespace Case_study_Fintech.Services
{
    interface IAccountService
    {
        public List<Account> GetAccounts();
        public Account GetAccount(int? id);
        public Account CreateAnAccount(Account account);
        public decimal GetBalance(int accountNumber);

    }
}
