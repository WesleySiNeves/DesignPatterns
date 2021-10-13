using PadraoAbstractFactory.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.AbstractProduct
{
    public abstract class Bolo : MassaBase
    {
        protected Bolo(string nome, TipoMassa tipoMassa) : base(nome, tipoMassa)
        {
        }
    }
}
