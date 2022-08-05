using System;

namespace FundamentosOO3Delegates
{
    internal class Program
    {
        static void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pago o valor de {valor}");
        }
        static void Main(string[] args)
        {
            // Delegates => Anonymous Methods
            var pagar = new Pagamento.Pagar(RealizarPagamento);
            pagar(25);
            Console.ReadKey();
        }
    }
    public class Pagamento
    {
        public delegate void Pagar(double valor);
    }
}
