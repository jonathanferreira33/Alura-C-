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
            //var funcionarios = criarFuncionarios();
            //gerenciador.CalculaBonificacao(funcionarios);

            //criarTitulatesEContas();
            //UsarSistema();

            Metodo(); // entender exceptions


            Console.ReadLine();

        }

        private static void Metodo()
        {
            TestaDivisao(2);
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine($"Resultado da divisão de 10 por {divisor} é igual {resultado} ");
        }

        private static int Dividir(int numero, int divisor)
        {
            return numero / divisor;
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            ParceiroComercial tainah = new ParceiroComercial();
            tainah.Senha = "1234";
            tainah.Autenticar("1234");


            Diretor kaido = new Diretor("Kaido","45612378990");
            kaido.Senha = "12345";
            Console.WriteLine($"Senha Kaido = {kaido.Senha}");

            sistemaInterno.Logar(kaido, "12345");
            sistemaInterno.Logar(tainah, "1234");
        }

        public static List<Funcionario> criarFuncionarios()
        {

            Funcionario roberto = new Assistente("Roberto Carlos", "12345678999");
            Funcionario nicole = new Diretor("Nicole Podestar", "12345678990");
            Funcionario jonathan = new Estagiario("Jonathan", "98765432100");



            nicole.AumentarSalario();
            Console.WriteLine($"Total de funcionários: {Funcionario.TotalFuncionario}");

            List<Funcionario> funcionarios = new List<Funcionario>();
            funcionarios.Add(roberto);
            funcionarios.Add(nicole);
            funcionarios.Add(jonathan);
            //funcionarios.Add(tainah);

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

            Console.WriteLine($"Total de contas: {ContaCorrente.TotalDeContas}");
            Console.WriteLine($"Valor taxa: {ContaCorrente.TaxaOperacao}");

            List<Titular> titulares = new List<Titular>();
            titulares.Add(jonathan);
            titulares.Add(tainah);

            //return titulares;
        }
        
    }
}
