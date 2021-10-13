using PadraoAbstractFactory.Factory.AbstractFactory;
using PadraoAbstractFactory.Product.AbstractProduct;
using PadraoAbstractFactory.Product.ConcreteProduct;

namespace PadraoAbstractFactory.Factory.ConcretFactory
{
    public class InfantilCardapioFactory : CardapioFactory
    {
        public override Sandwich CreateSandwich()
        {
            return new GrilledCheese();
        }

        public override Sobremesa CreateSobremesa()
        {
            return new IceCreamSundae();
        }
    }
}
