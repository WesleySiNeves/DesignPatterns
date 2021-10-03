using DesignPatterns.Creator;
using DesignPatterns.Product.Abstract;
using DesignPatterns.Product.Concrect;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ConcreteCreator
{
    public class PlatiumFactory : CartaoFactory
    {
        private int _limiteCredito;
        private int _cobrancaAnual;

        public PlatiumFactory(int limiteCredito, int cobrancaAnual)
        {
            _limiteCredito = limiteCredito;
            _cobrancaAnual = cobrancaAnual;

        }
        public override CartaoCredito NewCreator()
        {
            return new CartaoPlatium(_limiteCredito, _cobrancaAnual);
        }
    }
}
