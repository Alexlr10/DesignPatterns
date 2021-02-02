using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class FactoryMethod
    {
        public IPersonagem EscolherPersonagem(string personagem)
        {
            switch (personagem)
            {
                case "Liu Kang":return new LiuKang();
                case "Scorpion": return new Scorpion();
                case "SubZero": return new SubZero();
                default: return null;
            }
        }
    }
}
