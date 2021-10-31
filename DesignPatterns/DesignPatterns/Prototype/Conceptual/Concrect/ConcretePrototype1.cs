using Conceptual.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptual.Concrect
{
    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1( Guid id)
            :base(id)

        {


        }

        public override Prototype ShallowCopy()
        {
            return (Prototype)this.MemberwiseClone();

        }

        public override Prototype DeepCopy()
        {
            throw new NotImplementedException();
        }
    }
}
