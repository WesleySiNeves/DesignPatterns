using System;

namespace ConceptualTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();
            // Set implementation and call

            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            Console.ReadKey();

            // Change implemention and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();
            // Wait for user
            Console.ReadKey();
        }
    }
}
