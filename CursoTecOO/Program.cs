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
            });
            
            central.SelecionarEExecutar();
        }
    }
}
