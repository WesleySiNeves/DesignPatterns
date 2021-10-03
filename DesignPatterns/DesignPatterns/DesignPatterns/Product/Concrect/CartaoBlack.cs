using DesignPatterns.Product.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Product.Concrect
{
    public class CartaoBlack : CartaoCredito
    {
        private readonly string _tipoCartao;
        private int _limiteCredito;
        private int _cobrancaAnual;

        public CartaoBlack(int limiteCredito, int cobrancaAnual)
        {
            this._tipoCartao = "Black";
            this._limiteCredito = limiteCredito;
            this._cobrancaAnual = cobrancaAnual;

        }

        public override string Tipo { get { return _tipoCartao; } }

        public override int LimiteCredito 
        {
            get { return _limiteCredito; } 
            set { _limiteCredito = value; } 
        }

        public override int CobrancaAnual 
        {
            get { return _cobrancaAnual; } 
            set { _cobrancaAnual = value; } 
        }
    }
}
