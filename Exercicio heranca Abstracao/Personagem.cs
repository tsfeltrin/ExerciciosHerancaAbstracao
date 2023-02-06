using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_heranca_Abstracao
{
    public abstract class Personagem
    {
        private string Nome { get; set; }
        private int Nivel { get; set; }

        public abstract string Atacar();

    }

    
}
