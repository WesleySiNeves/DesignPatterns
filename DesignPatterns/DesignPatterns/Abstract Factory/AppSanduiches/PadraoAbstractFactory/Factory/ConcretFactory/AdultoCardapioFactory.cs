using PadraoAbstractFactory.Factory.AbstractFactory;
using PadraoAbstractFactory.Product.AbstractProduct;
using PadraoAbstractFactory.Product.ConcreteFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Factory.ConcretFactory
{
    public class AdultoCardapioFactory : CardapioFactory
    {
        public override Sandwich CreateSandwich()
        {
            return new  SandwichBacon();
        }

        public override Sobremesa CreateSobremesa()
        {
            return new Pudin();
        }
    }
}
