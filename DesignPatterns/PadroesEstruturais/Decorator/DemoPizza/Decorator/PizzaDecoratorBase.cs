using DemoPizza.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPizza.Decorator
{
    public class PizzaDecoratorBase : IPizza
    {
        private readonly IPizza _pizza;

        public PizzaDecoratorBase(IPizza p)
        {
            _pizza = p;
        }
        public virtual string BuscarTipoPizza()
        {
            var pizza =   _pizza.BuscarTipoPizza();

            return pizza;
        }
    }
}
