using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBank
{
    public class LeitorDeArquivos : IDisposable
    {
        public string Arquivo { get; }
        public LeitorDeArquivos(string arquivo)
        {
            Arquivo = arquivo;
            int divisor = 0;
            int resultado = 10 / divisor;

            throw new FileNotFoundException();
            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }
        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");

            throw new IOException();
            return "linha do arquivo";
        }
      
        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}
