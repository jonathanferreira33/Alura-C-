

using BankYellow.Sistemas;

namespace BankYellow.Funcionarios

{
    internal class Diretor : FuncionarioAutenticavel
    {
        public string Senha { get; set; }

        public Diretor(string nome, string cpf) : base(nome, cpf) //base referece ao que foi declarado na classe base
        {
            this.Salario = 10000.0;
            //base.Nome = nome; forma de utilizar metodos ou propriedades da classe base
        }

      
        public override double GetBonificacao()
        {
           return this.Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario = Salario * 1.15;
        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

    }
}
