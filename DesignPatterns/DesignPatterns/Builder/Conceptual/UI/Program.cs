using System;
using Conceptual;
using Conceptual.Builder.Contract;
using Conceptual.Directors;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
                // O código do cliente cria um objeto construtor, passa-o para o
             // diretor e, em seguida, inicia o processo de construção. O fim
             // o resultado é recuperado do objeto construtor.
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard basic product:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            // Remember, the Builder pattern can be used without a Director
            // class.
            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.Write(builder.GetProduct().ListParts());

            Console.ReadLine();
        }
    }
}
