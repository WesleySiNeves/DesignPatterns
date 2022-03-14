using CartaoCredito.ConcreteCreator;
using CartaoCredito.Creator;
using System;

namespace CartaoCredito.Client
{
    class Program
    {
        /// <summary>
        /// Define uma  interface de criação de objeto  , mas deixa sua subclasse decidir qual classe deve ser instanciada
        /// considerado um construtor virtual
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CartaoFactory cartaoFactory = null;

            Console.WriteLine("Digite o tipo de cartão que vc quer ?:");
            string console = Console.ReadLine();

            switch (console.ToLower())
            {
                case "black":
                    cartaoFactory = new BlackFactory(50000, 0);
                    break;
                case "titanium":
                    cartaoFactory = new TitaniumFactory(500000, 500);
                    break;
                case "platium":
                    cartaoFactory = new PlatiumFactory(5000000, 1000);
                    break;


                default:
                    break;
            }


            IProduct.CartaoCredito cartaoCredito = cartaoFactory.NewCreator();

            Console.WriteLine("Cartão criado:" + cartaoCredito.Tipo);
            Console.WriteLine("Limite anual:" + cartaoCredito.LimiteCredito);
            Console.WriteLine("Cobrança anual:" + cartaoCredito.CobrancaAnual);
            Console.ReadKey();






        }
    }
}
