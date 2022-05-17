using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankYellow.Exceptions
{
    internal class SaldoInsuficienteException : Exception
    {

        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {

        }
        public SaldoInsuficienteException(string message) : base(message)
        {

        }

        public SaldoInsuficienteException( double saldo, double valorSaque) :
            this($"Tentativa de saque no valor de R$: {valorSaque}. Saldo de R$ {saldo} é insuficiente!")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
    }
}
