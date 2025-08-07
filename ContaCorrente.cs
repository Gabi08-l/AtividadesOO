using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeOO
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(string banco, int agencia, int conta, decimal saldo, decimal limite) : base(banco, agencia, conta, saldo)
        {
            this.Limite = limite;
        }
        public decimal Limite { get; set; }
    }
}
