using System;

namespace FundamentosOO5Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var payment = new Payment();
            var subscription = new Subscription();
            var context = new DataContext<Person, Payment, Subscription>();
            context.Save(person);
            context.Save(payment);
            context.Save(subscription);
        }
    }

    public class DataContext<P, PA, S>
        where P : Person
        where PA : Payment
        where S : Subscription
    {
        

        public void Save(P entity)
        {
            
        }
        public void Save(PA entity)
        {

        }
        public void Save(S entity)
        {

        }
    }

    
    public class Person
    {
     
    }

    public class Payment
    {

    }

    public class Subscription
    {

    }
}
