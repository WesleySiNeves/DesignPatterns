using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeConceptual
{
    /// <summary>
    /// representa objetos folha na composição. Uma folha não tem filhos.
    /// define o comportamento de objetos primitivos na composição.
    /// </summary>
    public class Leaf : Component
    {
        public override string Operation()
        {
            return "Leaf";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
