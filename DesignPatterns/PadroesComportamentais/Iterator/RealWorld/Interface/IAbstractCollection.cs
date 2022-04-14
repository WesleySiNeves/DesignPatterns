using RealWorld.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld.Aggregate
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
