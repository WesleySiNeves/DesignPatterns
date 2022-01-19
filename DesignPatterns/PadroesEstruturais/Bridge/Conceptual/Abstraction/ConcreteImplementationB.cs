using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptual
{

    /// <summary>
    /// ConcreteImplementor   
    /// implementa a interface do Implementor e define sua implementação concreta.
    /// </summary>
    class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform B.\n";
        }
    }
}
