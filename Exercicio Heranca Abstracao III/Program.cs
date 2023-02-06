using System;

namespace Exercicio_Heranca_Abstracao_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comum comum = new Comum();
            Vip vip = new Vip();

            comum.Saldo = 100;
            vip.Saldo = 100;

            string retorno = comum.RealizarAposta(30);
            Console.WriteLine(retorno);

            retorno = vip.RealizarAposta(20);
            Console.WriteLine(retorno);

        }
    }
}
