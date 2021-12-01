using DemoPizza.Concrect;
using DemoPizza.ConcrectDecorator;
using DemoPizza.Interface;
using System;

namespace DemoPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();

            Console.WriteLine(pizza.BuscarTipoPizza());

            Console.ReadKey();


            IPizza queijoDecorator = new QueijoDecorator(pizza);


            Console.WriteLine(queijoDecorator.BuscarTipoPizza());

            Console.ReadKey();



            IPizza baconDecorator = new BaconDecorator(queijoDecorator);

            Console.WriteLine(baconDecorator.BuscarTipoPizza());

            Console.ReadKey();


            IPizza peperoniDecorator = new PepperoniDecorator(baconDecorator);

            Console.WriteLine(peperoniDecorator.BuscarTipoPizza());

            Console.ReadKey();
        }
    }
}
