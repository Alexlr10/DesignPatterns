using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //é o nosso Adaptee - ele é o objeto que será adaptado.
    public class RoboInimigo
    {
        Random gerador = new Random();
        
        public void EsmagarComMaos()
        {
            int DanoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine("O Robo Inimigo causou " + DanoAtaque + " de dano com o ataque Esmagar com as Mãos.");
        }

        public void AndarFrente()
        {
            int movimento = this.gerador.Next(10) + 1;
            Console.WriteLine("O Robo Inimigo andou "+ movimento + " passos para frente!");
        }

        public void ReagirContraHumano(String piloto)
        {
            Console.WriteLine("O Robo Inimigo vai contra "+ piloto);
        }
    }
}
