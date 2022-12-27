using Conceptual.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptual.Concrect
{
    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(Guid id)
            : base(id)
        {

        }

        public override Prototype ShallowCopy()
        {
            return (Prototype)this.MemberwiseClone();
        }


        public override Prototype DeepCopy()
        {
            throw new NotImplementedException("Metodo não implementado");
        }
    }
}
