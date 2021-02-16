using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Video : ItemBiblioteca
    {
        public string Diretor { get; set; }
        public string Titulo { get; set; }
        public int MinutosDuracao { get; set; }


        public Video(string diretor, string titulo, int minutosDuracao, int numCopias)
        {
            this.Diretor = diretor;
            this.Titulo = titulo;
            this.NumeroCopias = numCopias;
            this.MinutosDuracao = minutosDuracao;
        }
        public override void Exibe()
        {
            Console.WriteLine("\nVideo ----");
            Console.WriteLine("Diretor: " + this.Diretor);
            Console.WriteLine("Titulo: " + this.Titulo);
            Console.WriteLine("Duracao: " + this.MinutosDuracao);
            Console.WriteLine("#Copias: " + this.NumeroCopias);
        }
    }
}
