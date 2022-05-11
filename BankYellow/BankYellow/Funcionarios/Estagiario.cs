

namespace BankYellow.Funcionarios
{
    internal class Estagiario : Funcionario
    {
        public Estagiario(string nome, string cpf) : base(nome, cpf, 2200.0)
        {
        }

        public override double GetBonificacao()
        {
           return Salario * 0.1;
        }

        public override void AumentarSalario()
        {
            base.AumentarSalario();
        }
    }
}
