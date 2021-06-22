using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Models
{
    public class Account
    {
        public int Id { get; set; }
        public User User { get; set;  }
        public int? AccountNumber { get; set; }
        public decimal Balance { get; set; }


        public bool HasBalance() {
            return Balance > 0;
        }

        public bool hasBalanceForValue(decimal value)
        {
            return Balance - value > 0;
        }
    }
}
