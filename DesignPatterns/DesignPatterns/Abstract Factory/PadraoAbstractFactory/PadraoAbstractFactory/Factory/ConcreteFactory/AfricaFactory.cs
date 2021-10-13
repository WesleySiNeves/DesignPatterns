using PadraoAbstractFactory.Factory.AbstractFactory;
using PadraoAbstractFactory.Product.AbstractProduct;
using PadraoAbstractFactory.Product.ConcreteFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Factory.ConcreteFactory
{
    public class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Leao();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Antilope();
        }
    }
}
