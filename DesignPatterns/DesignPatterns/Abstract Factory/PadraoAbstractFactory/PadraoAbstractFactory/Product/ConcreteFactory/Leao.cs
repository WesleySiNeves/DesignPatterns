using PadraoAbstractFactory.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.ConcreteFactory
{
    public class Leao : Carnivore
    {
        public override void Comer(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name +
               " comendo " + h.GetType().Name);
        }
    }
}
