using System.Globalization;

namespace CursoTecOO.Exercicios.ClassesExtras
{
    class Funcionario
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string cpf, string nome, double salario)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Salario = salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario = porcentagem * Salario / 100.0 + Salario;
        }

        public override string ToString()
        {
            return Cpf + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
