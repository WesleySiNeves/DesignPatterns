namespace CartaoCredito.ConcreteCreator
{
    /// <summary>
    /// Implementação do Factory
    /// Sobrescreve a classe Virtual ou implementa a interface 
    /// </summary>
    public class BlackFactory : Creator.CartaoFactory
    {
        private int _limiteCredito;
        private int _cobrancaAnual;

        public BlackFactory(int limiteCredito, int cobrancaAnual)
        {
            _limiteCredito = limiteCredito;
            _cobrancaAnual = cobrancaAnual;

        }
        public override IProduct.CartaoCredito NewCreator()
        {
            return new ProductConcrete.CartaoBlack(_limiteCredito, _cobrancaAnual);
        }
    }
}
