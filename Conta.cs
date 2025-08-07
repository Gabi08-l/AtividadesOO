using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeOO
{
    public class Conta
    {
        public string Banco;
        public int Agencia;
        public int Numero;
        public decimal Saldo;
        public int conta;
        public object Limite { get; set; }

        public decimal SaldoTotal()
        {
            return SaldoTotal();
        }

        public Conta(string banco, int agencia, int numero, decimal saldo, int conta)
        {
            Banco = banco;
            Agencia = agencia;
            Numero = numero;
            Saldo = saldo;
            this.conta = conta;
            Limite = new object();
        }

        public decimal Depositar(int v)
        {
            if (v <= 0)
            {
                Console.WriteLine("Deposito invalido. O valor deve ser maior que zero");
                return 0;
            }
            else
            {
                Saldo += v;
                return Saldo;
            }
        }

        public decimal Sacar(int v)
        {
            if (v > 0 && v <= Saldo)
            {
                Saldo -= v;
            }
            return Saldo;
        }
    }
}
