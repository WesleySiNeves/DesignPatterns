using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptual
{
    class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.OperationOnSubsystem1And2());

            Console.ReadKey();

            Console.Write(facade.OperationOnSubsystem1And2And3());
        }
    }
}
