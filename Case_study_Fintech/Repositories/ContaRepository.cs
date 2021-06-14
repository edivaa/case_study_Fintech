using Case_study_Fintech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Repositories
{
    public class ContaRepository
    {
        private List<Account> contas;

        public ContaRepository()
        {
          contas  = new List<Account>() {
                new Account() { Name = "Antonio", LastName = "Santos", Email = "antonio@gmail.com", AccountNumber = 12556, Balance =1000000 },
                new Account() { Name = "Antonio", LastName = "Santos", Email = "antonio@gmail.com", AccountNumber = 32897, Balance =4000000 },
                new Account() { Name = "Antonio", LastName = "Santos", Email = "antonio@gmail.com", AccountNumber = 45896, Balance =9000000 },
                 new Account() { Name = "Robson", LastName = "Santana", Email="robson@gmail.com"   , AccountNumber=58996, Balance =0 }
        };
        }

        public List<Account> GetContas()
        {
            return contas;
        }

        public Account GetConta(int? numConta)
        {
            return contas.FirstOrDefault(c=>c.AccountNumber == numConta);
        }

        public Account AdicinarConta(Account conta) {
            contas.Add(conta);

            return GetConta(conta.AccountNumber);
        }

    }
}
