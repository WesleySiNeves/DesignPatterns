using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.AbstractProduct
{
    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>
    public abstract class Carnivore
    {
        public abstract void Comer(Herbivore h);
    }
}
