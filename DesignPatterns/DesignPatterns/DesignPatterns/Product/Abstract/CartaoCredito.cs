namespace DesignPatterns.Product.Abstract
{

    /// <summary>
    /// Factory Method Pattern sempre te retorna um produto
    /// meu produto define a interface dos objetos 
    /// </summary>
    public abstract class CartaoCredito
    {

        public abstract string Tipo { get; }

        public abstract int LimiteCredito { get; set; }

        public abstract int CobrancaAnual { get; set; }
    }
}
