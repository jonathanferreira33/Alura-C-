using BankYellow.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankYellow
{
    internal class ContaCorrente
    {
        public static int ContadorDeTransferenciaNaoPermitidas { get; private set; }
        public static int ContadorDeSaquesNaoPermitidos { get; private set; }
        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContas { get; private set; }
        public int Agencia { get; } // sem o set tonar-se um campo de somente leitura

        public int Numero { get; }



        private double Saldo;

        private double _limite;
        public double Limite
        {
            get
            {
                return _limite;
            }
            set
            {
                if (value > 1000) _limite = 1000;
                _limite = value;
            }
        }

        public Titular Titular;

        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0) throw new ArgumentException("Agência deve ser maior que zero(0).", nameof(agencia)); // nameof operador c#
            if (numero <= 0) throw new ArgumentException("Número deve ser maior que zero (0).", nameof(agencia));

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

        public void Sacar(double valor)
        {

            if (valor < 0) throw new ArgumentException("Valor inválido para saque", nameof(valor));

            if (Saldo < valor)
            {
                ContadorDeSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(this.Saldo, valor);
            }
            Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0) throw new ArgumentException("Valor inválido para transferência", nameof(valor));

            try
            {
                this.Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorDeTransferenciaNaoPermitidas++;
                throw ex;
            }
            contaDestino.Depositar(valor);

        }
    }
}
