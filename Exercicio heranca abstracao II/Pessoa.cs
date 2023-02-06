using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_heranca_abstracao_II
{
    public abstract class Pessoa
    {
        private string Nome { get; set; }
        private int Idade { get; set; }
        public abstract string Trabalhar();
    }
}
