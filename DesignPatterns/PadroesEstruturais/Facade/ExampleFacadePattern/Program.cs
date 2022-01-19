using ExampleFacadePattern.Facade;
using System;

namespace ExampleFacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var facade = new RestauranteFacade();



            Console.WriteLine("####------------- Pedidos de pizza do Cliente-------------####\n");
            facade.BuscarPizzaNormal();
            facade.BuscarPizzaVegana();


            Console.WriteLine("####------------- Pedidos de Pão do Cliente-------------####\n");
            facade.BuscarPaoAlho();
            facade.BuscarPaoAlhoComQueijo();

        }
    }
}
