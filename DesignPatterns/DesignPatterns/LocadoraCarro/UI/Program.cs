using PadraoFactoryMethod.Factory;
using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of wheels between 1 and 12 to build a vehicle and press enter");

            var wheels = Console.ReadLine();
            var vehicle = VeiculoFactory.Build(Convert.ToInt32(wheels));
            Console.WriteLine($" You built a {vehicle.GetType().Name}");
            Console.Read();
        }
    }
}
