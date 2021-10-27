using System;
using Conceptual;
using Conceptual.Builder.Concrect;
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

            Console.WriteLine("Personagem sem Pernas:");
            director.BuildPersonagemSemPernas();
            Console.WriteLine(builder.GetProduct().GetParts());


            Console.WriteLine("Personagem sem Braços:");
            director.BuildPersonagemSemBraços();
            Console.WriteLine(builder.GetProduct().GetParts());


            Console.WriteLine("Personagem Completo:");
            director.BuildPersonagemCompleto();
            Console.WriteLine(builder.GetProduct().GetParts());

            // Remember, the Builder pattern can be used without a Director
            // class.
            Console.WriteLine("Custom product:");
            builder.BuildBracos();
            builder.BuildCabeca();
            Console.Write(builder.GetProduct().GetParts());

            Console.ReadLine();
        }
    }
}
