using PadraoAbstractFactory.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.ConcreteProduct
{
    public class Lobo : Carnivore
    {
        public override void Comer(Herbivore h)
        {
            Console.WriteLine(GetType().Name +
               " Comendo " + h.GetType().Name);
        }
    }
}
