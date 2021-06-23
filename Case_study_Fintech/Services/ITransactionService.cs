using Case_study_Fintech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Services
{
    interface ITransactionService
    {
        public Decimal TransferByPix(int? accountNumber, decimal value);
        public List<AccountTransaction> TransferHistory(int accountNumber);
    }
}
