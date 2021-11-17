using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptual
{
    public abstract class Prototype
    {


        // Gets id
        public Guid Chassi { get; set; }

        public abstract Carro ShallowCopy();

        public abstract Carro DeepCopy();
    }
}
