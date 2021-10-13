using DemoSimple.ProductConcret;

namespace DemoSimple.ConcrectCreator
{
    class ConcreteCreator2 : Creator.Creator
    {
        public override IProduct.IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
