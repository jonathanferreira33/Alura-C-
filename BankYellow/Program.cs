using BankYellow.Exceptions;
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
            //UsarSistema();

            try
            {
                criarTitulatesEContas();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.ParamName);
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Saldo insuficiente");
            }

            try
            {
                Metodo(); // entender exceptions
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Aconteceu um erro: {ex.Message}");
                //Console.WriteLine($"Aconteceu um erro: {ex.StackTrace}");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Impossivel realizar divisão por zero");
            }
          
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadLine();

        }

        private static void Metodo()
        {
            TestaDivisao(2);
            TestaDivisao(20);
        }

        private static void TestaDivisao(int divisor)
        {

            int resultado = Dividir(10, divisor);

        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Exceção devido divisão de {numero} e divisor {divisor}");
                throw; // throw (em português, "lançar"). Ou seja, estamos lançando a exceção que aconteceu no bloco try, e que catch está pegando
            }
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            ParceiroComercial tainah = new ParceiroComercial();
            tainah.Senha = "1234";
            tainah.Autenticar("1234");


            Diretor kaido = new Diretor("Kaido", "45612378990");
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

            ContaCorrente contaC = new ContaCorrente(0001, 1455);
            contaC.Depositar(50);
            contaC.Sacar(50);
            contaC.Transferir(10.0, contaB);
            Console.WriteLine($"Saldo contaC =  {contaC.getSaldo()}");


            Console.WriteLine($"Total de contas: {ContaCorrente.TotalDeContas}");
            Console.WriteLine($"Valor taxa: {ContaCorrente.TaxaOperacao}");

            List<Titular> titulares = new List<Titular>();
            titulares.Add(jonathan);
            titulares.Add(tainah);

            //return titulares;
        }

    }
}
