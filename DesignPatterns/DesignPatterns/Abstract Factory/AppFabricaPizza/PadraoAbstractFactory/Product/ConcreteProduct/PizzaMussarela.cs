using PadraoAbstractFactory.Product.AbstractProduct;
using PadraoAbstractFactory.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.ConcreteProduct
{
    public class PizzaMussarela : Pizza
    {
        public PizzaMussarela(string nome, TipoMassa tipoMassa) : base("Pizza de Mussarela", tipoMassa)
        {
            ingredientes.Add("Queijo Mussarela");
            ingredientes.Add("Massa um pouco mais grossa com borda");
            ingredientes.Add("Fatias de Bacon");
        }

    }
}
