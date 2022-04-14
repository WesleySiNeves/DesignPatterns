using RealWordClienteGenerics.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWordClienteGenerics.Interface
{
    public interface IAbstractAggregate
    {
        ConcreteIterator CreateIterator();
    }
}
