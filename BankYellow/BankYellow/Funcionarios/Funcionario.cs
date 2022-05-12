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



        public string CPF { get; private set; }
        public double Salario { get; protected set; } // protected modificador para ser acessivel pela classe + tipos derivados


        public static int TotalFuncionario { get; private set; } 

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            CPF = cpf;
            Salario = salario;

            TotalFuncionario++;
        }

        public abstract double GetBonificacao();

        public virtual void AumentarSalario() // virtual significa que as classes filhas podem realizar override ou ñ
        {
            //Salario = Salario + (Salario * 0.1);
            //Salario = Salario * 1.1;
            this.Salario *= 1.1;
        }
    }
}
