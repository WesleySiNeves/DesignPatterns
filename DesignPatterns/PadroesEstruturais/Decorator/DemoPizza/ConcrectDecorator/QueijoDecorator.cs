using DemoPizza.Decorator;
using DemoPizza.Interface;

namespace DemoPizza.ConcrectDecorator
{
    //Concret Decorator
    public class QueijoDecorator : PizzaDecoratorBase
    {
        public QueijoDecorator(IPizza p) 
            : base(p)
        {

        }
        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();

            pizza += "\n Com extra de queijo";

            return pizza;

        }
    }
}
