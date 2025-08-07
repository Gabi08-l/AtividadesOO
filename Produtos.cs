using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeOO
{
    internal class Produtos
    {
        public required string Nome { get; set; }
        public int Codigo { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }


        public decimal ValorEstoque()
        {
            return Preco * Estoque;
        }

    }
}
