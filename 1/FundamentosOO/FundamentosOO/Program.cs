using System;

namespace FundamentosOO
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //tipo de referencia
            // -> Endereço dos dados
            /*var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Pagar();
            pagamentoBoleto.Vencimento = DateTime.Now;
            pagamentoBoleto.numeroBoleto = "123";*/

            /*var pagamento = new Pagamento();
            pagamento.DataPagamento = DateTime.Now;
            Console.ReadKey();*/

        }
      
    }
    // tipos de Classe:
    // private, protected, internal e public
    /*private class Pagamento
    {
        //variaveis se tornam PROPRIEDADES
        //DateTime Vencimento;

        //Adress BillingAdress;
        //funcoes se tornam metodos  

        /*public string NumeroBoleto;

        public DateTime Vencimento { get; set; } // prop + tab

        private DateTime _dataPagamento;

        public DateTime DataPagamento 
        {
            get {
                Console.WriteLine("Lendo o valor");
                return _dataPagamento; }
            set {
                Console.WriteLine("Atribuindo o valor");
                _dataPagamento = value; }
        }*/// propfull

        //public int MyProperty { get; private set; } // propg
        /*
        public virtual void Pagar(string numero) //virtual para sobreescrever
        {

        }
        public void Pagar(string numero, DateTime Vencimento/*, bool pagarAposVencimento = false*/)
        //{

        //}

        // PRIVATE fica exclusivo para a classe pagamento
    //}
    
    
    /*class PagamentoBoleto : Pagamento
    {
        public string numeroBoleto;

        public override void Pagar()
        {
            //regra boleto
        }
        public override string ToString()
        {
            return Vencimento.ToString("dd/M/yy");
        }
    }

    class PagamentoCartaoCredito : Pagamento
    {
        public string numero;

        public override void Pagar()
        {
            //regra cartao
        }
    }*/
}
