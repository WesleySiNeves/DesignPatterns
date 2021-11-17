using PadraoAbstractFactory.Product.AbstractProduct;
using PadraoAbstractFactory.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.ConcreteProduct
{
    public class PizzaCalabresa : Pizza
    {


        public PizzaCalabresa(string nome, TipoMassa tipoMassa) : base("Pizza de Calabresa", tipoMassa)
        {
            ingredientes.Add("Queijo Mussarela");
            ingredientes.Add("Rodelas de Calabresa");
            ingredientes.Add("Fatias de Bacon");
        }

    }
}
