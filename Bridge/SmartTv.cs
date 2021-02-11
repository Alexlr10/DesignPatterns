using System;

namespace Bridge
{
    public class SmartTv
    {
        //Aqui temos a ponte (Bridge).
        //No program chama essa interface e passamos para ela o objeto
        public ICanal canalAtual { get; set; }

        public void ExibeCanalSintonizado()
        {
            if(canalAtual != null)
                Console.WriteLine(canalAtual.Canal());
            else
                Console.WriteLine("Por favor, selecione um canal");
        }

        public void PlayTv()
        {
            if (canalAtual != null)
                Console.WriteLine(canalAtual.Status());
            else
                Console.WriteLine("Por favor, selecione um canal para assistir algo");

        }

    }
}
