using Case_study_Fintech.Models;
using Case_study_Fintech.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Services
{
    public class TransacaoService
    {
        readonly AccountService contaService;
         private Random random = new Random();
        public TransacaoService()
        {
            contaService = new AccountService();
        }
        public List<Account> GetContas()
        {
            return contaService.GetAccounts();
        }
    
        public Decimal SacarPix(int? numConta, decimal valor) {

               var conta = contaService.GetAccount(numConta);
                if(!conta.HasBalance()) {
                    throw new Exception("Conta sem saldo");
                } 

               return conta.Balance-valor;
        }
    }
}
