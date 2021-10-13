namespace CartaoCredito.ConcreteCreator
{
    public class PlatiumFactory : Creator.CartaoFactory
    {
        private int _limiteCredito;
        private int _cobrancaAnual;

        public PlatiumFactory(int limiteCredito, int cobrancaAnual)
        {
            _limiteCredito = limiteCredito;
            _cobrancaAnual = cobrancaAnual;

        }
        public override IProduct.CartaoCredito NewCreator()
        {
            return new ProductConcrete.CartaoPlatium(_limiteCredito, _cobrancaAnual);
        }
    }
}
