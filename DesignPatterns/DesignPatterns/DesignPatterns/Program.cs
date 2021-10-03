using DesignPatterns.ConcreteCreator;
using DesignPatterns.Creator;
using DesignPatterns.Product.Abstract;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoFactory cartaoFactory = null;

            Console.WriteLine("Digite o tipo de cartão que vc quer ?:");
            string console = Console.ReadLine();

            switch (console)
            {
                case "Black":
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


            CartaoCredito cartaoCredito  =   cartaoFactory.NewCreator();

            Console.WriteLine(cartaoCredito.Tipo);
            Console.WriteLine(cartaoCredito.LimiteCredito);
            Console.WriteLine(cartaoCredito.CobrancaAnual);
            Console.ReadKey();






        }
    }
}
