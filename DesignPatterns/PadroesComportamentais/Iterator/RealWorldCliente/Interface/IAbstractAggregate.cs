using RealWorldCliente.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorldCliente.Interface
{
    public interface IAbstractAggregate
    {
        ConcreteIterator CreateIterator();
    }
}
