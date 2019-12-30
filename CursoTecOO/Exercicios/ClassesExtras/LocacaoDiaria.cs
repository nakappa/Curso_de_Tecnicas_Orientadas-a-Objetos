using System.Globalization;

namespace CursoTecOO.Exercicios.ClassesExtras
{
    class LocacaoDiaria : Locacao
    {
        public int Dias { get; set; }

        public LocacaoDiaria(int numero, int dias) : base(numero)
        {
            Dias = dias;
        }

        public override double Preco()
        {
            return Dias * 20.0;
        }

        public override string ToString()
        {
            return "Locação: " + Numero + ", Dias: " + ", Preço Total: R$" + Preco().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
