using Case_study_Fintech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Repositories
{
    public class TransactionRepository
    {
        private List<Transaction> transacoes;
        private Random random = new Random();

        public TransactionRepository()
        {
            transacoes = new List<Transaction>() {
                new Transaction() { TransactionID =1 ,AccountNumber=12556, TransactionDate = new DateTime(2021,2,4), TransactionType="D", TransactionValue =50000 },
                new Transaction() { TransactionID =2 ,AccountNumber=12556, TransactionDate = new DateTime(2021,1,5), TransactionType="D", TransactionValue =40000 },
                new Transaction() { TransactionID =3 ,AccountNumber=45896, TransactionDate = new DateTime(2021,1,6), TransactionType="D", TransactionValue =9000  },
                new Transaction() { TransactionID =4 ,AccountNumber=58996, TransactionDate = new DateTime(2021,5,6), TransactionType="D", TransactionValue =2001  }
            };

        }



        public List<Transaction> GetTransactions(int? accountNumber)
        {
            return transacoes.Where(c => c.AccountNumber == accountNumber).ToList();
        }

        public Transaction GetTransaction(int transactionId)
        {
            return transacoes.FirstOrDefault(t => t.TransactionID == transactionId);
        }
        public Transaction AddTrasaction(Transaction transaction) {

            transaction.TransactionID = random.Next(5, 100000);

            transacoes.Add(transaction);

            return transaction;
        }

    }
}
