using BankYellow.Funcionarios;
using System;

namespace BankYellow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Titular jonathan = new Titular();
            jonathan.Nome = "Jonathan";
            jonathan.Profissao = "Dev";
            jonathan.CPF = "12345678999";

            ContaCorrente contaA = new ContaCorrente(0001, 1234);
            contaA.Titular = jonathan;
            contaA.setSaldo(15000.0);


            Titular tainah = new Titular();
            tainah.Nome = "Tainah";
            tainah.Profissao = "Vendas";
            tainah.CPF = "12345677799";

            ContaCorrente contaB = new ContaCorrente(0001, 1235);
            contaB.Titular = tainah;
            contaB.setSaldo(1000.0);

            contaB.Transferir(100.0, contaA);

            Console.WriteLine(contaA.getSaldo());
            Console.WriteLine(contaB.getSaldo());
            Console.WriteLine(ContaCorrente.TotalDeContas);


            Funcionario roberto = new Assistente("Roberto Carlos", "12345678999", 15000.0);
            Funcionario nicole = new Diretor("Nicole Podestar", "12345678990", 10000.0);

            Console.WriteLine(roberto.GetBonificacao());
            Console.WriteLine(nicole.GetBonificacao());

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            gerenciador.Registrar(roberto);
            gerenciador.Registrar(nicole);
            Console.WriteLine($"Total de bonificações: {gerenciador.GetBonificacao()}");



            Console.ReadLine();

        }
    }
}
