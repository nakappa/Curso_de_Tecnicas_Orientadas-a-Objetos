using System;
using System.Collections.Generic;
using System.Text;

namespace CursoTecOO.Exercicios
{
    class Conjuntos
    {
        public static void Executar()
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int quantAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < quantAlunos; i++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            Console.WriteLine();
            Console.Write("O curso B possui quantos alunos? ");
            quantAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int i = 0; i < quantAlunos; i++)
            {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }

            Console.WriteLine();
            Console.Write("O curso C possui quantos alunos? ");
            quantAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int i = 0; i < quantAlunos; i++)
            {
                int x = int.Parse(Console.ReadLine());
                C.Add(x);
            }

            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(B);
            Novo.UnionWith(C);

            Console.WriteLine();
            Console.WriteLine("Total de Alunos: " + Novo.Count);
        }
    }
}
