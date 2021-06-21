using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
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
