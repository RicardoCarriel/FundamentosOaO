using System;
using System.Collections.Generic;
using System.Linq;

namespace FundamentosOO6Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //var payments = new List<Payment>();
            //payments.Add(new Payment(1));
            //payments.Add(new Payment(2));
            //payments.Add(new Payment(3));
            //payments.Add(new Payment(4));

            IEnumerable<Payment> payments = new List<Payment>();

            //foreach(var item in payments)
            //{
            //  Console.WriteLine(item.Id);
            //}

            payments.ToList();

            //var payment = payments.First(x=>x.Id == 3);
            //Console.WriteLine(payment.Id);

            //payments.Remove(payment);
                   
            

            Console.ReadKey();
        }
    }

    public class Payment
    {
        public int Id { get; set; }

        public Payment(int id)
        {
            Id = id;
        }
    }
}
