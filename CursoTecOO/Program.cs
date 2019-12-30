using System;
using System.Collections.Generic;
using CursoTecOO.Exercicios;

namespace CursoTecOO
{
    class Program
    {
        static void Main()
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                {  "Vetores - Técnicas de orientação a objetos e estruturas de dados", Vetores.Executar  },
                {  "Matrizes - Técnicas de orientação a objetos e estruturas de dados", Matrizes.Executar  },
                {  "Listas - Técnicas de orientação a objetos e estruturas de dados", Listas.Executar  },
                {  "Conjuntos - Técnicas de orientação a objetos e estruturas de dados", Conjuntos.Executar  },
            });
            
            central.SelecionarEExecutar();
        }
    }
}
