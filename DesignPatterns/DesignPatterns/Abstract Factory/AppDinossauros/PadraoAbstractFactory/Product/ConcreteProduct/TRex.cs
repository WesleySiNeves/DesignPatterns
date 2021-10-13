using PadraoAbstractFactory.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.ConcreteFactory
{
    public class TRex : IDinosaur
    {
        public void Grunir()
        {
            Console.WriteLine("RAWWR!");
        }
    }
}
