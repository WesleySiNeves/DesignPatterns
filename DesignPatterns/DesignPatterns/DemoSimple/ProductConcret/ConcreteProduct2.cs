using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSimple.ProductConcret
{
    public class ConcreteProduct2 : DemoSimple.IProduct.IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
