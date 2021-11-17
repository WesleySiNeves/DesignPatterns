namespace CartaoCredito.ConcreteCreator
{
    public class TitaniumFactory : Creator.CartaoFactory
    { 
        private int _limiteCredito;
        private int _cobrancaAnual;

        public TitaniumFactory(int limiteCredito, int cobrancaAnual)
        {
            _limiteCredito = limiteCredito;
            _cobrancaAnual = cobrancaAnual;

        }
        public override IProduct.CartaoCredito NewCreator()
        {
            return new ProductConcrete.CartaoTitanium(_limiteCredito, _cobrancaAnual);
        }
    }
}
