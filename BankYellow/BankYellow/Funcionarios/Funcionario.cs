using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankYellow.Funcionarios
{
    internal abstract class Funcionario
    {
        //0 - estagiario
        //1 - assistente
        //2 - gerente
        //3 - diretor
        //private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            CPF = cpf;
            Salario = salario;
        }

        public abstract double GetBonificacao();
    }
}
