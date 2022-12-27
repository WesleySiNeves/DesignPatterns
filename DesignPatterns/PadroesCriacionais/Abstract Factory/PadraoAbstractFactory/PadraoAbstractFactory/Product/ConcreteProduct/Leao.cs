using PadraoAbstractFactory.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.ConcreteProduct
{
    public class Leao : Carnivore
    {
        public override void Comer(Herbivore h)
        {
            Console.WriteLine(GetType().Name +
               " comendo " + h.GetType().Name);
        }
    }
}
