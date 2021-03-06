﻿using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioPermanente func_permanente = new FuncionarioPermanente();
            func_permanente.Nome = "Joao";
            func_permanente.Idade = 30;
            func_permanente.Tipo = "Permanente";

            FuncionarioPermanente clone_func_permanente = (FuncionarioPermanente)func_permanente.Clone();
            clone_func_permanente.Nome = "Carlos";
            clone_func_permanente.Idade = 40;

            Console.WriteLine("Detalhe do Funcionario Permanente:");
            Console.WriteLine("Nome: {0}; Idade: {1}; Tipo: {2}", func_permanente.Nome, func_permanente.Idade, func_permanente.Tipo);

            Console.WriteLine("Detalhe do Funcionario Clonado:");
            Console.WriteLine("Nome: {0}; Idade: {1}; Tipo: {2}", clone_func_permanente.Nome, clone_func_permanente.Idade, clone_func_permanente.Tipo);

            Console.ReadKey();
        }
        
    }
}
