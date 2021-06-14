using Case_study_Fintech.Models;
using Case_study_Fintech.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Services
{
    public class ContaService
    {
        readonly ContaRepository contaRepository;
         private Random random = new Random();
        public ContaService()
        {
            contaRepository = new ContaRepository();
        }
        public List<Account> GetContas()
        {
            return contaRepository.GetContas();
        }
        public Account GetConta(int? id)
        {
            return contaRepository.GetConta(id);
        }
        public Account CreateConta(Account conta) {

               var contaExiste = contaRepository.GetConta(conta.AccountNumber);
               if(contaExiste != null) {
                   throw new Exception("Conta ja existe");
               }else {
                   conta.AccountNumber = random.Next(0, 10000);
                   contaRepository.AdicinarConta(conta);
               }

               return conta;
        }
    }
}
