using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //é o nosso Adapter - o adaptador do objeto Robo com Tanque
    public class RoboInimigoAdapter : IAtaqueInimigo
    {
        RoboInimigo robo;
        //Passa para o método construtor o robo que será adaptado (nosso adaptee)
        public RoboInimigoAdapter(RoboInimigo novoRobo)
        {
            this.robo = novoRobo;
        }

        public void ArmaFogo()
        {
            this.robo.EsmagarComMaos();
        }

        public void Movimenta()
        {
            this.robo.AndarFrente();
        }

        public void Pilotar(string piloto)
        {
            this.robo.ReagirContraHumano(piloto);
        }
    }
}
