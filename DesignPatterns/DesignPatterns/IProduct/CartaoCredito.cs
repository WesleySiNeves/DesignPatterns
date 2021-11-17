using CartaoCredito.ValueObjects;

namespace CartaoCredito.IProduct
{

    /// <summary>
    /// Factory Method Pattern sempre te retorna um produto
    /// meu produto define a interface dos objetos 
    /// </summary>
    public abstract class CartaoCredito
    {

        public abstract CartaoType Tipo { get; }

        public abstract int LimiteCredito { get; set; }

        public abstract int CobrancaAnual { get; set; }

    }
}
