using ByteBank.Modelos;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaInterno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(0001, 654321);
            Console.WriteLine(conta.Saldo);

            DateTime dataFim = new DateTime(2022, 06, 30);
            DateTime dataAtual = DateTime.Now; // propridade estatica


            TimeSpan diferenca = dataFim - dataAtual;
            string msg = "vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(dataAtual);
            Console.WriteLine(dataFim);
            Console.WriteLine(msg);



            Console.ReadLine();
        }

        //forma suspeita
        static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        {
            if (timeSpan.Days > 1)
                return timeSpan.Days + "em dias";
            else if (timeSpan.Hours > 1)
                return timeSpan.Hours + "em horas";
            else if (timeSpan.Minutes >= 1)
                return timeSpan.Minutes + "em minutos";
            else
                return "atingido!";

        }
    }
}
