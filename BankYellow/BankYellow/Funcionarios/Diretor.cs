using BankYellow.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankYellow.Funcionarios

{
    internal class Diretor : Funcionario
    {

        public Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public override double GetBonificacao()
        {
           return this.Salario * 0.2;
        }
    }
}
