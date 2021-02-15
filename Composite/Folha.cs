using System;

namespace Composite
{
    public class Folha : Componente
    {
        //Trazer informacao da classe pai
        public Folha(string nome) : base(nome)
        {

        }
        public override void Adicionar(Componente c)
        {
            Console.WriteLine("Não foi possivel adicionar a folha!");
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new String('-', profundidade) + nome);
        }

        public override void Remover(Componente c)
        {
            Console.WriteLine("Não é possivel remover a folha!");
        }
    }
}
