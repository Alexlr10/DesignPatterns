using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Componente
    {
        protected string nome;

        public Componente(string nome)
        {
            this.nome = nome;
        }

        public abstract void Adicionar(Componente c);
        public abstract void Remover(Componente c);
        public abstract void Mostrar(int profundidade);
    }
}
