using CartaoCredito.ValueObjects;

namespace CartaoCredito.ProductConcrete
{
    public class CartaoTitanium : IProduct.CartaoCredito
    {
        private readonly CartaoType _tipoCartao;
        private int _limiteCredito;
        private int _cobrancaAnual;

        public CartaoTitanium(int limiteCredito, int cobrancaAnual)
        {
            this._tipoCartao = CartaoType.Titanium;
            this._limiteCredito = limiteCredito;
            this._cobrancaAnual = cobrancaAnual;

        }

        public override CartaoType Tipo { get { return _tipoCartao; } }

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
