using PadraoAbstractFactory.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.ConcreteFactory
{
    class Braquiossauro : IDinosaur
    {
        public void Grunir()
        {
            Console.WriteLine("BRUMMR!");
        }
    }
}
