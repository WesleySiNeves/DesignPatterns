using PadraoAbstractFactory.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.ConcreteFactory
{
    class Antilope : Herbivore
    {
        public override void Comer()
        {
            Console.WriteLine("Antilope : Estou comendo folhas na africa!");
        }
    }
}
