using DemoPizza.Decorator;
using DemoPizza.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPizza.ConcrectDecorator
{
    class PepperoniDecorator : PizzaDecoratorBase
    {
        public PepperoniDecorator(IPizza p)
            : base(p)
        {

        }
        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();

            pizza += "\n Com extra de pepperoni";

            return pizza;

        }
    }
}

