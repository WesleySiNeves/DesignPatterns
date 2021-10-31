using Conceptual.Concrect;
using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype1 p1 = new ConcretePrototype1(Guid.NewGuid());

            ConcretePrototype1 c1 = (ConcretePrototype1)p1.ShallowCopy();

            Console.WriteLine("Cloned: {0}", c1.Id);
            ConcretePrototype2 p2 = new ConcretePrototype2(Guid.NewGuid());

            ConcretePrototype2 c2 = (ConcretePrototype2)p2.ShallowCopy();

            Console.WriteLine("Cloned: {0}", c2.Id);
            // Wait for user
            Console.ReadKey();
        }
    }
}
