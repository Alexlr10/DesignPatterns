using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar um Livro
            Livro livro = new Livro("João", "Design Patterns", 10);
            livro.Exibe();

            //Criar um Video
            Video video = new Video("Rodrigo", "Video Aulas Avançadas", 25, 3);
            video.Exibe();

            //Vou emprestar um video e mostrar na tela
            Console.WriteLine("\nEmprestando um Video: ");

            Emprestado emprestado = new Emprestado(video);
            emprestado.EmprestarItem("Carlos");
            emprestado.EmprestarItem("Maria");

            emprestado.Exibe();

            Console.WriteLine("\nDevolvendo um Video: ");
            emprestado.DevolverItem("Carlos");
            emprestado.Exibe();
            Console.ReadKey();

        }
    }
}
