using BankYellow.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankYellow
{
    public class ParceiroComercial : FuncionarioAutenticavel
    {
        public ParceiroComercial(string nome, string cpf) : base(nome, cpf)
        {
        }

        public string Senha { get; private set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

        public override double GetBonificacao()
        {
            return 0;
        }
    }
}
