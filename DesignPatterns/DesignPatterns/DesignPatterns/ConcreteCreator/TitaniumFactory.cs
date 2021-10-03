using DesignPatterns.Creator;
using DesignPatterns.Product.Abstract;
using DesignPatterns.Product.Concrect;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ConcreteCreator
{
    public class TitaniumFactory : CartaoFactory
    { 
        private int _limiteCredito;
        private int _cobrancaAnual;

        public TitaniumFactory(int limiteCredito, int cobrancaAnual)
        {
            _limiteCredito = limiteCredito;
            _cobrancaAnual = cobrancaAnual;

        }
        public override CartaoCredito NewCreator()
        {
            return new CartaoTitanium(_limiteCredito, _cobrancaAnual);
        }
    }
}
