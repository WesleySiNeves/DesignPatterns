using System;

namespace Conceptual.Contract
{


    public abstract class Prototype
    {

        
        // Constructor
        public Prototype(Guid id)
        {
            this.Id = id;
        }
        // Gets id
        public Guid Id { get; set; } 
        
        public abstract Prototype ShallowCopy();

        public abstract Prototype DeepCopy();
    }
}
