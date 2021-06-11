using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Models
{
    public class Conta
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public int? NumConta { get; set; }
        public decimal Saldo { get; set; }


        public bool possuiSaldo(){
            return Saldo > 0 ;
        }
    }
}
