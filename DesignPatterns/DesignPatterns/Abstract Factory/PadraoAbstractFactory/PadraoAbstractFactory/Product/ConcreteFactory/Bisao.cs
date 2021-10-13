﻿using PadraoAbstractFactory.Product.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.ConcreteFactory
{
    class Bisao : Herbivore
    {
        public override void Comer()
        {
            Console.WriteLine("Bisao : Estou comendo folhas na américa!");
        }
    }
}
