﻿using System;
using CursoTecOO.Exercicios.ClassesExtras;

namespace CursoTecOO.Exercicios
{
    class Vetores
    {
        public static void Executar()
        {
            Aluguel[] quartos = new Aluguel[10];

            Console.Write("Quantos aluguéis serão registrados? ");
            int quantRegistros = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= quantRegistros; i++)
            {
                Console.WriteLine("Dados do " + i + "º aluguel:");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int pos = int.Parse(Console.ReadLine());
                quartos[pos] = new Aluguel(nome, email);
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++) if (quartos[i] != null) Console.WriteLine(i + ": " + quartos[i]);
        }
    }
}
