using System;
using System.IO;

namespace BankYellow
{
    internal class LeitorDeArquivo : IDisposable
    {

        public string Arquivo { get; }
        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;
            int divisor = 0;
            //int resultado = 10 / divisor;
            //throw new FileNotFoundException();
            Console.WriteLine($"Abrindo arquivo: {arquivo}");
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo proxima linha ...");
            throw new IOException();
            return "Linha do arquivo";
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando arquivo");
        }

        public void Dispose() // metodo que deve liberar os recursos
        {
            Console.WriteLine("lendo Dispose");
        }
    }
}
