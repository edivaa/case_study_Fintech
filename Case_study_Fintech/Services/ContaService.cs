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
        public List<Conta> GetContas()
        {
            return contaRepository.GetContas();
        }
        public Conta GetConta(int id)
        {
            return contaRepository.GetConta(id);
        }
        public Conta CreateConta(Conta conta) {

               var contaExiste = contaRepository.GetConta(conta.NumConta);
               if(contaExiste != null) {
                   throw new Exception("Conta ja existe");
               }else {
                   conta.NumConta = random.Next(0, 10000);
                   contaRepository.AdicinarConta(conta);
               }

               return conta;
        }
    }
}
