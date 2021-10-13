using DemoSample.Factory.AbstractFactory;
using DemoSample.Factory.ConcrectFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSample.Client
{
    public class Client
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testando o código do cliente com o primeiro tipo de fábrica...");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Testando o mesmo código de cliente com o segundo tipo de fábrica...");
            ClientMethod(new ConcreteFactory2());
        }


        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
            Console.ReadKey();
        }
    }
}
