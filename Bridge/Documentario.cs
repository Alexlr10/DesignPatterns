using System;

namespace Bridge
{
    public class Documentario: ICanal
    {
        public string Canal()
        {
            return ("Sintonizado no Canal de Filmes");
        }

        public string Status()
        {
            return ("Voce está assistindo - A Origem de tudo");
        }
    }
}
