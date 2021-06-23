using System;


namespace Case_study_Fintech.Models
{
    public class AccountTransaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal TransactionValue { get; set; }
        public string TransactionType { get; set; }
        public int? AccountNumber { get; set; }
    }
}
