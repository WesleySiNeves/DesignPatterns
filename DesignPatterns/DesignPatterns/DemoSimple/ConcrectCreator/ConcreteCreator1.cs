using DemoSimple.ProductConcret;

namespace DemoSimple.ConcrectCreator
{
    public  class ConcreteCreator1 : Creator.Creator
    {
        public override IProduct.IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
