using Conceptual.DecoratorConcrect.DecoratorBase;
using Conceptual.Interface;

namespace Conceptual.Concrect
{
    class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component comp)
            : base(comp)
        {
        }
        // Decorators may call parent implementation of the operation, instead
        // of calling the wrapped object directly. This approach simplifies
        // extension of decorator classes.
        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }
}
