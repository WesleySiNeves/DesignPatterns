using DesignPatterns.Product.Abstract;

namespace DesignPatterns.Creator
{
    /// <summary>
    /// E uma classe abstrata  wque declara um Factory (creador de objetos)
    /// </summary>
    public abstract class CartaoFactory
    {
        public abstract CartaoCredito NewCreator();
    }
}
