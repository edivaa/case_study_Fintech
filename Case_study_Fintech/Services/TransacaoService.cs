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
        readonly ContaService contaService;
         private Random random = new Random();
        public TransacaoService()
        {
            contaService = new ContaService();
        }
        public List<Account> GetContas()
        {
            return contaService.GetContas();
        }
    
        public Decimal SacarPix(int? numConta, decimal valor) {

               var conta = contaService.GetConta(numConta);
                if(!conta.HasBalance()) {
                    throw new Exception("Conta sem saldo");
                } 

               return conta.Balance-valor;
        }
    }
}
