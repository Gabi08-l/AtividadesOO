﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtividadeOO;

namespace AtividadeOO
{
    public class Capivara : Animal
    {
        public string? Nome { get; set; }
        public Capivara(string especie, string nome)
        {
            this.Especie = especie;
            this.Nome = nome;
        }

    }
}