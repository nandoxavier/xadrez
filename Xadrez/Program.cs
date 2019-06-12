using System;
using tabuleiro;
using xadrez;


namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos.toPosicao());
        }
    }
}
