using System.Globalization;

namespace CursoTecOO.Exercicios.ClassesExtras
{
    class LocacaoAnual : Locacao
    {
        public int Ano { get; set; }
        public double PorcentagemDesconto { get; set; }

        public LocacaoAnual(int numero, int ano, double porcentagemDesconto) : base(numero)
        {
            Ano = ano;
            PorcentagemDesconto = porcentagemDesconto;
        }

        public override double Preco()
        {
            double desconto = 3000.0 * PorcentagemDesconto / 100.0;
            return 3000.0 - desconto;
        }

        public override string ToString()
        {
            return "Locação: " + Numero + ", Ano: " + Ano + ", Desconto: " + PorcentagemDesconto.ToString("F2", CultureInfo.InvariantCulture) + "%, Preço Total: R$" + Preco().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
