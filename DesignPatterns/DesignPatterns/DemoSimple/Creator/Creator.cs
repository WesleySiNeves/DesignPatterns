using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSimple.Creator
{

    // A classe Creator declara o método de fábrica que deve retornar
    // um objeto de uma classe Product.
    public abstract class Creator
    {
        public abstract DemoSimple.IProduct.IProduct FactoryMethod();


        public string SomeOperation()
        {
            // Call the factory method to create a Product object.
            var product = FactoryMethod();


            var result = "Creator: The same creator's code has just worked with "
                + product.Operation();

            return result;
        }
    }
}
