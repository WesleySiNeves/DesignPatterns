using Conceptual;
using Conceptual.Adapter;
using Conceptual.Legado;
using Conceptual.Target;
using System;

namespace Client
{
    class Program
    {
        protected static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();

            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());

            Console.ReadKey();
        }
    }
}
