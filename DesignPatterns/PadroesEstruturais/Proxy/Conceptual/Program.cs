using Conceptual.Business;
using Conceptual.ClasseProxy;
using Conceptual.Cliente;
using System;

namespace Conceptual
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            client.ClientCode(realSubject);

            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            Proxy proxy = new Proxy(realSubject);
            client.ClientCode(proxy);

            Console.ReadKey();

        }
    }
}
