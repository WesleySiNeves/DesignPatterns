using DemoSample.Factory.AbstractFactory;
using DemoSample.Product.AbstractProduct;
using DemoSample.Product.ConcretProduct;

namespace DemoSample.Factory.ConcrectFactory
{
    /// <summary>
    /// implementa as operações para criar objetos de produto concretos
    /// </summary>
    public class ConcreteFactory2 :IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
