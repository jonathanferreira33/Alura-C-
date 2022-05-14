using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankYellow
{
    internal class ContaCorrente
    {
        public static int TotalDeContas { get; private set; }
        public static double TaxaOperacao { get; private set; }

        public int Numero { get; set; }
        public int Agencia { get; set; }
        public int _agencia { 
            get
            {
                return _agencia;
            }
            set
            {
                if(value > 0)
                {
                    _agencia = value;
                } 
                else
                {
                    return ;
                }
            }
        }

        private double Saldo;

        private double _limite;
        public double Limite
        {
            get {
                return _limite;
                }
            set { 
                if (value > 1000) _limite = 1000;
                _limite = value;
                }
        }

        public Titular Titular;

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContas++;
            TaxaOperacao = 30 / TotalDeContas;
        }

        public double getSaldo()
        {
            return Saldo;
        }


        public double setSaldo(double valor)
        {
            return (valor < 0) ? Saldo : Saldo = valor;
        }

        public bool Sacar(double valor)
        {
            return this.Saldo <= valor ? false : true;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.Saldo < valor) return false;

            this.Saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }
    }
}
