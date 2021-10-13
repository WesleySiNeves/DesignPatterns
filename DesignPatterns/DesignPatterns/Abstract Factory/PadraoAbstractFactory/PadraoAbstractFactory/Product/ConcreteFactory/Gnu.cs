using PadraoAbstractFactory.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.ConcreteFactory
{
    /// <summary>
    /// The 'ProductA1' class
    /// </summary>

    public class Gnu : Herbivore
    {
        public override void Comer()
        {
            Console.WriteLine("Gnu:Estou comendo folhas");
        }
    }
}
