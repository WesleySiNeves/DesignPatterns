﻿using System.Collections;

namespace Conceptual.Interface
{
    abstract class IteratorAggregate 
        //: IEnumerable
    {
        // Returns an Iterator or another IteratorAggregate for the implementing
        // object.
        public abstract IEnumerator GetEnumerator();
    }
}
