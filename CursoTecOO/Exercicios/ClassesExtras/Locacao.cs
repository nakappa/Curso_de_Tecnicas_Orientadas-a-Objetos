namespace CursoTecOO.Exercicios.ClassesExtras
{
    abstract class Locacao
    {
        public int Numero { get; set; }

        public Locacao(int numero)
        {
            Numero = numero;
        }

        public abstract double Preco();
    }
}
