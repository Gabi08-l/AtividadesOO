using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeOO
{
    public class Livros
    {
        public required string Titulo { get; set; }
        public required string Autor { get; set; }    // required, obrigatório, impossivel registrar um livro sem tirulo,autor e editora
        public required string Editora { get; set; }
        public int AnoLancamento { get; set; }
    }
}
