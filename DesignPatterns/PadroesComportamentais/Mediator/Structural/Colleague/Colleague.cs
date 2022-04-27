using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Structural.Colleague
{
    /// <summary>
    /// The 'Colleague' abstract class
    /// </summary>
    public abstract class Colleague
    {
        protected Mediator.Mediator mediator;
        // Constructor
        public Colleague(Mediator.Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
