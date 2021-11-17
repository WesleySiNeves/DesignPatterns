using PadraoFactoryMethod.ConcreteProduct;
using PadraoFactoryMethod.IProduct;
using PadraoFactoryMethod.ValueObjects;

namespace PadraoFactoryMethod.ConcrectCreator
{
    //ConcreteCreator
    public class PizzaFactorySP : Creator.PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Calabresa:
                    return new PizzaCalabresaSP();
                case PizzaType.Mussarela:
                    return new PizzaMussarelaSP();

                case PizzaType.Margarita:
                    return new PizzaMargaritaSP();
                default: return null;
            }
        }
    }
}
