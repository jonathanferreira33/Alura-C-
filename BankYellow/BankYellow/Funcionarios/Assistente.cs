using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankYellow.Funcionarios
{
    internal class Assistente : Funcionario
    {
        public Assistente(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public override double GetBonificacao()
        {
            return Salario * 0.15;
        }
    }
}
