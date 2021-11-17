using DemoSample.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSample.Product.ConcretProduct
{
    public class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
        }
    }
}
