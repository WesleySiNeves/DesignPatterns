
using PadraoAbstractFactory.Factory.ConcreteFactory;
using System;
using UI.Client;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var americanFactory = new AmericanFactory();

            AnimalWorld animalWorld = new AnimalWorld(americanFactory);
            animalWorld.RunFoodChain();


            var africafactory = new AfricaFactory();

            AnimalWorld animalWorld_2 = new AnimalWorld(africafactory);
            animalWorld_2.RunFoodChain();

            Console.ReadKey();
        }
    }
}
