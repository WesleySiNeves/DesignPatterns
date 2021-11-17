using PadraoAbstractFactory.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.ConcreteFactory
{
    public class Lobo : Carnivore
    {
        public override void Comer(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name +
               " Comendo " + h.GetType().Name);
        }
    }
}
