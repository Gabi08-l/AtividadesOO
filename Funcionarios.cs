using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtividadeOO;

namespace AtividadeOO
{
    internal class Funcionarios(string nome, int idade, string cargo) : Pessoa(nome, idade)
    {
        public string Cargo { get; set; } = cargo;

        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome} | Idade: {Idade} | Cargo: {Cargo} ");
        }
    }
}


