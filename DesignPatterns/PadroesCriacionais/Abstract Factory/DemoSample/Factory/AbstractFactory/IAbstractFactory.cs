using DemoSample.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSample.Factory.AbstractFactory
{
    /// <summary>
    /// declara uma interface para operações que criam produtos abstratos
    /// </summary>
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }
}
