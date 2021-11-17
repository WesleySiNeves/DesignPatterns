
namespace CartaoCredito.Creator
{
    /// <summary>
    /// E uma classe abstrata  que declara um Factory (creador de objetos)
    /// </summary>
    public abstract class CartaoFactory
    {
        public abstract IProduct.CartaoCredito NewCreator();
    }
}
