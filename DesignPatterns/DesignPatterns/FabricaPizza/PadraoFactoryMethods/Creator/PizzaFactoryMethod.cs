
using PadraoFactoryMethod.ValueObjects;
using System;

namespace PadraoFactoryMethod.Creator
{
    //Creator
    public abstract class PizzaFactoryMethod
    {
        public IProduct.Pizza MontarPizza(PizzaType type)
        {
            return CriarPizza(type);
        }
        protected abstract IProduct.Pizza CriarPizza(PizzaType type);
    }
}
