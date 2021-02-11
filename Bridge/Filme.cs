using System;

namespace Bridge
{
    public class Filme : ICanal
    {
        const String canal = "Canal de Filmes";
        public string Canal()
        {
            return ("Sintonizado no Canal de filmes");
        }

        public string Status()
        {
            return ("Voce está assistindo - Os Vingadores");
        }
    }
}
