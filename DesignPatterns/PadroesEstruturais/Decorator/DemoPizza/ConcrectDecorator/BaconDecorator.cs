using DemoPizza.Decorator;
using DemoPizza.Interface;

namespace DemoPizza.ConcrectDecorator
{
    public class BaconDecorator : PizzaDecoratorBase
    {
        public BaconDecorator(IPizza p)
            : base(p)
        {

        }
        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();

            pizza += "\n Com extra de bacon";

            return pizza;

        }
    }
}

