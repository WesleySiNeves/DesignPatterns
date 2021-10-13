using PadraoFactoryMethod.ConcrectCreator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PadraoFactoryMethod.Factory
{
    public class PizzariaFactory
    {
        public static Creator.PizzaFactoryMethod NewPizzaria(string estado)
        {
            switch (estado)
            {
                case var _ when new List<string> { "S", "SP", "São Paulo" }.Any(x => x == estado): return new PizzaFactorySP();
                case var _ when new List<string> { "R", "RJ", "Rio de janeiro" }.Any(x => x == estado): return new PizzaFactoryRJ();
                default:
                    throw new ArgumentException("Estado não abrangido");

            }
        }
    }
}
