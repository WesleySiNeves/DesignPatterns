using PadraoAbstractFactory.ValueObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Product.AbstractProduct
{
    public abstract class MassaBase
    {
        public virtual string Nome { get; set; }

        public virtual string Massa { get; set; }

        public virtual string Molho { get; set; }

        protected  ArrayList ingredientes = new ArrayList();

        public TipoMassa Tipo { get; set; }

        public virtual List<string> Mensagens { get; set; }

        public MassaBase(string nome , TipoMassa tipoMassa)
        {
            Nome = nome;
            Tipo = tipoMassa;

        }
    }
}
