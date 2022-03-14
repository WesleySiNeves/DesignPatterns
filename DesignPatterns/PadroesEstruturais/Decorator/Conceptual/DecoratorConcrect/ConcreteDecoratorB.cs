using Conceptual.DecoratorConcrect.DecoratorBase;
using Conceptual.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptual.DecoratorConcrect
{
    class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component comp)
            : base(comp)
        {

        }
        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    }
}
