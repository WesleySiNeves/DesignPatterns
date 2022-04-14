using RealWorldCliente.Collection;
using RealWorldCliente.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorldCliente.Concrete
{
    public class ConcreteAggregate : IAbstractAggregate
    {
        List<Cliente> items = new List<Cliente>();
        public ConcreteIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public void AddCliente(Cliente cliente)
        {
            items.Add(cliente);
        }
       
        // Indexer
        public Cliente GetCliente(int index)
        {
             return items[index];
           
        }

        // Gets item count
        public int Count
        {
            get { return items.Count; }
        }

    }
}
