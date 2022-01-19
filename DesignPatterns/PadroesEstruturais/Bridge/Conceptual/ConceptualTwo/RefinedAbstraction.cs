using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptualTwo
{

    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    /// 
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
