using System;

namespace Exercicio_heranca_abstracao_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario fn = new Funcionario();
            string retorno = fn.Trabalhar();
            Console.WriteLine(retorno);
        }
    }
}
