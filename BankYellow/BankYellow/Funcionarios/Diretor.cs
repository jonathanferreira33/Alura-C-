

namespace BankYellow.Funcionarios

{
    internal class Diretor : Funcionario
    {

        public string Senha { get; set; }

        public Diretor(string nome, string cpf) : base(nome, cpf, 10000.0) //base referece ao que foi declarado na classe base
        {
            //base.Nome = nome; forma de utilizar metodos ou propriedades da classe base
        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha; 
        }

        public override double GetBonificacao()
        {
           return this.Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario = Salario * 1.15;
        }
    }
}
