using PadraoAbstractFactory.Product.AbstractProduct;
using PadraoAbstractFactory.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.ConcreteProduct
{
    public class BoloChocolate : Bolo
    {
        public BoloChocolate(string nome, TipoMassa tipoMassa) 
            : base("Bolo Chocolate", tipoMassa)
        {
            ingredientes.Add("Cobertura de chocolate meio amargo");
        }
    }
}
