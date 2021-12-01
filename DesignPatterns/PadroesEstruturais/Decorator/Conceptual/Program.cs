using System;
using Conceptual.Cliente;
using Conceptual.Concrect;

namespace Conceptual
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(simple);
            Console.WriteLine();


            Console.ReadKey();


            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorator1);

            Console.ReadKey();

            // // Observe como os decoradores podem envolver não apenas componentes simples, mas também
            // outros decoradores também.
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(simple);
            client.ClientCode(decorator2);

            Console.ReadKey();





            ConcreteDecoratorB decorator3 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorator3);

            Console.ReadKey();
        }
    }
}
