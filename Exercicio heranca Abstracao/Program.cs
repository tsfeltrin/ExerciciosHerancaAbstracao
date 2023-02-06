using System;

namespace Exercicio_heranca_Abstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador jogador = new Jogador();

            string retorno = jogador.Atacar();
            Console.WriteLine(retorno);
        }
    }
}
