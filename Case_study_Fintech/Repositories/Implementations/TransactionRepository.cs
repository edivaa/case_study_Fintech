using Case_study_Fintech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Repositories.Implementations
{
    public class TransactionRepository
    {
        private List<AccountTransaction> transacoes;
        private Random random = new Random();

        public TransactionRepository()
        {
            transacoes = new List<AccountTransaction>() {
                new AccountTransaction() { Id =1 ,AccountNumber=12556, TransactionDate = new DateTime(2021,2,4), TransactionType="D", TransactionValue =50000 },
                new AccountTransaction() { Id =2 ,AccountNumber=12556, TransactionDate = new DateTime(2021,1,5), TransactionType="D", TransactionValue =40000 },
                new AccountTransaction() { Id =3 ,AccountNumber=45896, TransactionDate = new DateTime(2021,1,6), TransactionType="D", TransactionValue =9000  },
                new AccountTransaction() { Id =4 ,AccountNumber=58996, TransactionDate = new DateTime(2021,5,6), TransactionType="D", TransactionValue =2001  }
            };

        }



        public List<AccountTransaction> GetTransactions(int? accountNumber)
        {
            return transacoes.Where(c => c.AccountNumber == accountNumber).ToList();
        }

        public AccountTransaction GetTransaction(int transactionId)
        {
            return transacoes.FirstOrDefault(t => t.Id == transactionId);
        }
        public AccountTransaction AddTrasaction(AccountTransaction transaction) {

            transaction.Id = random.Next(5, 100000);

            transacoes.Add(transaction);

            return transaction;
        }

    }
}
