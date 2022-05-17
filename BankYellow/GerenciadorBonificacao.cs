using BankYellow.Funcionarios;
using System;
using System.Collections.Generic;


namespace BankYellow
{
    internal class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetBonificacaoTotal()
        {
            return _totalBonificacao;
        }

        public void CalculaBonificacao(List<Funcionario> funcionarios)
        {

            foreach (Funcionario funcionario in funcionarios) { 
                Registrar(funcionario);

            Console.WriteLine($"Salário : {funcionario.Salario}");
            }

            Console.WriteLine($"Total de bonificações : {_totalBonificacao}");
        }
    }
}
