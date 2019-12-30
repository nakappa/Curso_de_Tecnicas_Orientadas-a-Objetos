using System;

namespace CursoTecOO.Exercicios
{
    class Matrizes
    {
        public static void Executar()
        {
            int M, N;

            Console.Write("Digite o nº de linhas e colunas: ");
            string[] s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);

            int[,] mat = new int[M, N];

            Console.WriteLine("Digite os valores que as linhas receberam em cada coluna: ");
            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) mat[i, j] = int.Parse(s[j]);
            }

            int X = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] == X)
                    {
                        if (j > 0) Console.WriteLine("Esquerda: " + mat[i, j - 1]);

                        if (i > 0) Console.WriteLine("Acima: " + mat[i - 1, j]);

                        if (j < N - 1) Console.WriteLine("Direita: " + mat[i, j + 1]);

                        if (i < M - 1) Console.WriteLine("Abaixo: " + mat[i + 1, j]);

                        // Solução paliativa para parar de varrer a matriz:
                        j = N;
                        i = M;
                    }
                }
            }
        }
    }
}
