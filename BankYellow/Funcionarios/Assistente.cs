

namespace BankYellow.Funcionarios
{
    internal class Assistente : Funcionario
    {
        public Assistente(string nome, string cpf) : base(nome, cpf) //base referece ao que foi declarado na classe base
        {
            this.Salario = 3000.0;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            Salario = Salario * 1.11;
        }
    }
}
