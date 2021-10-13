using PadraoFactoryMethod.ConcreteProduct;
using PadraoFactoryMethod.IProduct;
using PadraoFactoryMethod.ValueObjects;

namespace PadraoFactoryMethod.ConcrectCreator
{

    //ConcreteCreator
    public class PizzaFactoryRJ : Creator.PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Calabresa:
                    return new PizzaCalabresaRJ();
                case PizzaType.Mussarela:
                    return new PizzaMussarelaRJ();
                case PizzaType.Margarita:
                    return new PizzaMargaritaRJ();
                default: return null;
            }
        }
    }
}
