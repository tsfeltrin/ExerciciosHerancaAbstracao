using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_heranca_abstracao_II
{
    public class Funcionario : Pessoa
    {
        public double Salario { get; set; }
        

        public override string Trabalhar()
        {
            return "Trabalhei!!!";
        }
    }
}
