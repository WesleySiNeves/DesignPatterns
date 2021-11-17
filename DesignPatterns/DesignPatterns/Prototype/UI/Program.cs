using Conceptual.Concrect;
using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {

            ///Isso devemos evitar;
            ConcretePrototype1 objeto1 = new ConcretePrototype1(Guid.NewGuid());

            var clone1 = objeto1;
            clone1.Id = Guid.NewGuid();


            Console.WriteLine("Pai: {0}", objeto1.Id);
            Console.WriteLine("Clone: {0}", clone1.Id);

            Console.ReadKey();


            ConcretePrototype1 objeto2 = new ConcretePrototype1(Guid.NewGuid());
            ConcretePrototype1 clone2 = (ConcretePrototype1)objeto2.ShallowCopy();

            clone2.Id = Guid.NewGuid();

            Console.WriteLine("Pai: {0}", objeto2.Id);
            Console.WriteLine("Cloned: {0}", clone2.Id);

            ConcretePrototype2 objeto3 = new ConcretePrototype2(Guid.NewGuid());
            ConcretePrototype2 clone3 = (ConcretePrototype2)objeto3.ShallowCopy();

            clone3.Id = Guid.NewGuid();


            Console.WriteLine("Pai: {0}", objeto3.Id);
            Console.WriteLine("Cloned: {0}", clone3.Id);

            // Wait for user
            Console.ReadKey();
        }
    }
}
