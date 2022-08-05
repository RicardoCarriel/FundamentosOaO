using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosOO
{
    internal class FundamentosOO1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var pagamento = new Pagamento1();
            Console.ReadKey();
        }
    }
    public class Pagamento1 : IDisposable
    {
        // Garbage Collector

        public Pagamento1()
        {
            Console.WriteLine("Iniciando o pagamento");
        }

        public void Dispose()
        {
            Console.WriteLine("Finalizando o pagamento");
        }
    }
}
