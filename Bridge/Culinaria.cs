using System;

namespace Bridge
{
    public class Culinaria : ICanal
    {
        public string Canal()
        {
            return ("Sintonizado no Canal de Culinária");
        }

        public string Status()
        {
            return ("Voce está assistindo - Receita de bolo de Laranja.");
        }
    }
}
