using System;

namespace Conceptual.Contract
{


    public abstract class Prototype
    {

        Guid id;
        // Constructor
        public Prototype(Guid id)
        {
            this.id = id;
        }
        // Gets id
        public Guid Id
        {
            get { return id; }
        }
        public abstract Prototype ShallowCopy();

        public abstract Prototype DeepCopy();
    }
}
