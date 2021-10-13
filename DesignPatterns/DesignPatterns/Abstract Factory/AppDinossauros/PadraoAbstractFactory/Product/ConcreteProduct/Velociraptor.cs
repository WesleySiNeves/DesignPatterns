using PadraoAbstractFactory.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.ConcreteProduct
{
    public class Velociraptor : IDinosaur
    {
        public void Grunir()
        {
            Console.WriteLine("HAAMMR!");
        }
    }
}
