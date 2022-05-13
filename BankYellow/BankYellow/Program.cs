using BankYellow.Funcionarios;
using BankYellow.Sistemas;
using System;
using System.Collections.Generic;

namespace BankYellow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            criarTitulatesEContas();

            var funcionarios = criarFuncionarios();
            gerenciador.CalculaBonificacao(funcionarios);


            Console.WriteLine($"Total de contas: {ContaCorrente.TotalDeContas}");

            Console.WriteLine($"Total de funcionários: {Funcionario.TotalFuncionario}");

            UsarSistema();


            Console.ReadLine();

        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor kaido = new Diretor("Kaido","45612378990");
            kaido.Senha = "123456";

            sistemaInterno.Logar(kaido, "123456");
        }

        public static List<Funcionario> criarFuncionarios()
        {
            Funcionario roberto = new Assistente("Roberto Carlos", "12345678999");
            Funcionario nicole = new Diretor("Nicole Podestar", "12345678990");
            Funcionario jonathan = new Estagiario("Jonathan", "98765432100");
            ParceiroComercial tainah = new ParceiroComercial("Tainah", "12365498700");

            nicole.AumentarSalario();

            List<Funcionario> funcionarios = new List<Funcionario>();
            funcionarios.Add(roberto);
            funcionarios.Add(nicole);
            funcionarios.Add(jonathan);
            funcionarios.Add(tainah);

            return funcionarios;

        }

        public static void criarTitulatesEContas()
        {
            Titular jonathan = new Titular();
            jonathan.Nome = "Jonathan";
            jonathan.Profissao = "Dev";
            jonathan.CPF = "12345678999";
            ContaCorrente contaA = new ContaCorrente(0001, 1234);
            contaA.setSaldo(15000.0);
            contaA.Titular = jonathan;

            Titular tainah = new Titular();
            tainah.Nome = "Tainah";
            tainah.Profissao = "Vendas";
            tainah.CPF = "12345677799";
            ContaCorrente contaB = new ContaCorrente(0001, 1235);
            contaB.Titular = tainah;
            contaB.setSaldo(1000.0);

            List<Titular> titulares = new List<Titular>();
            titulares.Add(jonathan);
            titulares.Add(tainah);

            //return titulares;
        }
        
    }
}
