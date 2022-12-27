using PadraoAbstractFactory.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Factory.AbstractFactory
{
    /// <summary>
    /// The AbstractFactory class, which defines methods for creating abstract objects.
    /// </summary>
    public abstract class CardapioFactory
    {
        public abstract Sandwich CreateSandwich();
        public abstract Sobremesa CreateSobremesa();
    }
}
