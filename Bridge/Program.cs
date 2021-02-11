using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartTv minhaTv = new SmartTv();
            Console.WriteLine("SELECIONE UM CANAL");
            Console.WriteLine(" 1 - Filmes. \n 2 - Documentarios. \n 3 - Culinária.");

            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.KeyChar)
            {
                case '1':
                    minhaTv.canalAtual = new Filme();
                    break;
                case '2':
                    minhaTv.canalAtual = new Documentario();
                    break;
                case '3':
                    minhaTv.canalAtual = new Culinaria();
                    break;
            }
            Console.WriteLine();

            minhaTv.ExibeCanalSintonizado();
            minhaTv.PlayTv();

            Console.ReadKey();
        }
    }
}
