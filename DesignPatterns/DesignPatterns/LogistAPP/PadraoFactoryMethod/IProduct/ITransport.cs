using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoFactoryMethod.IProduct
{
    public interface ITransport
    {
        string Carregar();

        string Transportar();
    }
}
