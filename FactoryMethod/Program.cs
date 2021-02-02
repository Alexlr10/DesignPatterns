using System;


namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            FactoryMethod fm = new FactoryMethod();

            Console.WriteLine("Liu Kang | Scorpion | SubZero");
            Console.WriteLine();

            Console.WriteLine("Escolha seu personagem");
            string escolha = Console.ReadLine();

            IPersonagem personagem = fm.EscolherPersonagem(escolha);
            Console.WriteLine();
            Console.WriteLine("Voce vai jogar com ");
            personagem.Escolhido();

            Console.ReadKey();
        }
    }
}
