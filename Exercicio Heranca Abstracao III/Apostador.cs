using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Heranca_Abstracao_III
{
    public abstract class Apostador
    {
        public string Nome { get; set; }    
        public double Saldo { get; set; }

        public abstract string RealizarAposta(double valorAposta);

    }
}
