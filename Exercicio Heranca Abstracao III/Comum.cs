using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Heranca_Abstracao_III
{
    internal class Comum : Apostador 
    {
        public override string RealizarAposta(double valorAposta)
        {
            if (Saldo < valorAposta)
            {
                return "Aposta não permitida, saldo insuficiente!!!";
            }
            else 
            {
                Saldo = Saldo - valorAposta;
                return "Aposta concluída!!!";
            }
        }
    }
}
