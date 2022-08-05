using System;
using System.Diagnostics.CodeAnalysis;

namespace FundamentosOO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var pagamento = new Pagamento();
            //pagamento.Dispose();

            //Pagamento.Vencimento = DateTime.Now;
            // TEM QUE TER O IDISPOSABLE
            //using (var pagamento = new Pagamento())
            //{
            //  Console.WriteLine("Processando o Pagamento");
            //}

            //var pagamento = new PagamentoBoleto();
            //var pessoa = new Person();
            //pessoa = new Personal();
            //pessoa = new Corporate();
            var person = new Person(1, "Ricardo Carriel");
            var personB = new Person(1, "Ricardo Carriel");
            Console.WriteLine(person.Equals(personB));
            Console.ReadKey();
        }
         
    }
    /*public abstract class Pagamento : IPayment
    {
        public DateTime Vencimento { get; set;}

        public virtual void Pagar(double valor)
        {
            
        }
    }
    public class PagamentoCartaoCredito : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }
    public class PagamentoBoleto : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }
    public class PagamentoApplePay : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }
    public interface IPayment
    {
        DateTime Vencimento { get; set; }

        void Pagar(double valor);
    }
    // Flunt */
    public class Person : IEquatable<Person>
    {
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Equals([AllowNull] Person other)
        {
            return Id == other.Id;
        }
    }
    /*public class Personal : Person
    {
        public string CPF { get; set; }
    }

    public class Corporate : Person
    {
        public string CNPJ { get; set; }
    }*/
  
}
