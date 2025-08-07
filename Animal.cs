using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeOO
{
    public class Animal
    {
        public string? Especie { get; set; }

        public virtual void EmitirSom()
        {
            Console.WriteLine($"O animal da especie {Especie} esta emitindo um som");

        }
    }
}


