using PadraoAbstractFactory.Product.AbstractProduct;
using PadraoAbstractFactory.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.ConcreteProduct
{
    public class BoloLaranja : Bolo
    {
        public BoloLaranja(string nome, TipoMassa tipoMassa)
            : base("Bolo De Laranja", tipoMassa)
        {
            ingredientes.Add("Cobertura de Calda de Laranja");
        }
    }
}
