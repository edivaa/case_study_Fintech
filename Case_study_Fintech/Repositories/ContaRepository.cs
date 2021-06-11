using Case_study_Fintech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Repositories
{
    public class ContaRepository
    {
        private List<Conta> contas;

        public ContaRepository()
        {
          contas  = new List<Conta>() {
                new Conta() { Nome = "Antonio", SobreNome = "Santos", Email = "antonio@gmail.com", NumConta = 12556, Saldo =1000000 }
          };
        }

        public List<Conta> GetContas()
        {
            return contas;
        }

        public Conta GetConta(int idConta)
        {
            return null;
        }

    }
}
