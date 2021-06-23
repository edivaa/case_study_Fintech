using Case_study_Fintech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Repositories
{
    public interface IAccountRepository
    {
        public List<Account> GetAccounts();
        public Account GetAccount(int? numConta);
        public Decimal GetBalance(int? numConta);
        public Account AddAccount(Account account);
    }
}
