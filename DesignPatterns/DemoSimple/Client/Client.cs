using DemoSimple.ConcrectCreator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSimple.Client
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("App: ConcreteCreator1");

            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: ConcreteCreator2");
            ClientCode(new ConcreteCreator2());

            
        }

        public void ClientCode(Creator.Creator creator)
        {
            
            Console.WriteLine("Client: Não conheço a classe do criador, mas ainda funciona" +
                "\n" + creator.SomeOperation());
            
        }
    }
}
