using System;
using System.Collections.Generic;
using System.Text;
using DemoSimple.IProduct;

namespace DemoSimple.ProductConcret
{
    public class ConcreteProduct1 : DemoSimple.IProduct.IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
