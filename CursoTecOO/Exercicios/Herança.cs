using System;
using System.Collections.Generic;
using System.Globalization;
using CursoTecOO.Exercicios.ClassesExtras;

namespace CursoTecOO.Exercicios
{
    class Herança
    {
        public static void Executar()
        {
            Console.Write("Quantas locações você vai registrar? ");
            int n = int.Parse(Console.ReadLine());

            List<Locacao> lista = new List<Locacao>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.Write($"A {i}ª locação será diária ou anual (d/a)? ");
                char tipo = char.Parse(Console.ReadLine());

                Locacao locacao;
                Console.Write("Número da locação: ");
                int numero = int.Parse(Console.ReadLine());

                if (tipo == 'd')
                {
                    Console.Write("Quantidade de dias: ");
                    int dias = int.Parse(Console.ReadLine());
                    locacao = new LocacaoDiaria(numero, dias);
                }
                else
                {
                    Console.Write("Ano: ");
                    int ano = int.Parse(Console.ReadLine());
                    Console.Write("Porcentagem de desconto: ");
                    double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    locacao = new LocacaoAnual(numero, ano, porcentagem);
                }

                lista.Add(locacao);
            }

            Console.WriteLine();
            Console.WriteLine("Listagem de locações:");
            foreach (Locacao locacao in lista) Console.WriteLine(locacao);

            double soma = 0.0;
            foreach (Locacao locacao in lista) soma += locacao.Preco();

            Console.WriteLine();
            Console.WriteLine("Total Geral: R$" + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
