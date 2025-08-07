using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeOO
{
    internal class Carros
    {
        public required string Marca { get; set; }
        public required string Modelo { get; set; }
        public required int Velocidade { get; set; }

        public int Acelerar(int v)
        {
            if (v > 0)
            {
                Velocidade += v;
            }
            return Velocidade;
        }

        public int Desacelerar(int v)
        {
            if (v > 0)
            {
                Velocidade -= v;
            }
            return Velocidade;
        }
    }
}
