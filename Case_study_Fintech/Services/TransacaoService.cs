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
        readonly ContaRepository contaRepository;
         private Random random = new Random();
        public TransacaoService()
        {
            contaRepository = new ContaRepository();
        }
        public List<Conta> GetContas()
        {
            return contaRepository.GetContas();
        }
    
        public Decimal SacarPix(int numConta) {

               //var contaExiste = contaRepository.GetConta(numConta);

               throw new NotImplementedException();
        }
    }
}
