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
    }
}
