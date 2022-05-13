using BankYellow.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankYellow.Sistemas
{
    public abstract class FuncionarioAutenticavel : Funcionario, Autenticavel
    {
        public string Senha { get; private set; }

        protected FuncionarioAutenticavel(string nome, string cpf) : base(nome, cpf)
        {
        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
