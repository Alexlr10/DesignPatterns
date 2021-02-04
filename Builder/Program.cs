using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria o fabricante 
            Fabricante fabricante = new Fabricante();

            //Permite que a classe builder esteja pronta
            ICelular celularBuilder = null;

            //Agora vamos criar um telefone android
            celularBuilder = new AndroidBuilder();
            fabricante.Construtor(celularBuilder);
            Console.WriteLine("Foi fabricado um celular "+ celularBuilder.Celular.Nome);
            Console.WriteLine("Camera "+ celularBuilder.Celular.camera);
            Console.WriteLine("Bateria "+ celularBuilder.Celular.bateria);
            Console.WriteLine("Sistema operacional "+ celularBuilder.Celular.sistema);
            Console.WriteLine("Tela "+ celularBuilder.Celular.tela);


            Console.ReadKey();
        }
    }
}
