using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //BolaSemSingleton jogador_1 = new BolaSemSingleton();
            Singleton jogador_1 = Singleton.GetInstancia;
            jogador_1.Mensagem("Jogador 1: A bola esta comigo no meio do campo.");

            //BolaSemSingleton jogador_2 = new BolaSemSingleton();
            Singleton jogador_2 = Singleton.GetInstancia;
            jogador_2.Mensagem("Jogador 2: Recebeu a bola.");

            //BolaSemSingleton jogador_3 = new BolaSemSingleton();
            Singleton jogador_3 = Singleton.GetInstancia;
            jogador_3.Mensagem("Jogador 3: Recebeu o lançamento na linha de fundo.");


            Console.ReadKey();
        }
    }
}
