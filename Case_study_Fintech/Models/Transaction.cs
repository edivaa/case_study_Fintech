using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Repositories
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal TransactionValue { get; set; }
        public string TransactionType { get; set; }
        public int? AccountNumber { get; set; }
    }
}
