using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_heranca_Abstracao
{
    public class Jogador : Personagem
    {
        public int Pontos { get; set; }

        public override string Atacar()
        {
            return "Ataquei!!!";
        }
    }

}
