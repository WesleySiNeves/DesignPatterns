using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptual
{
    /// <summary>
    /// RefinedAbstraction   
    /// estende a interface definida por Abstraction.
    /// </summary>
    class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                base._implementation.OperationImplementation();
        }

    }
}
