using RealWordClienteGenerics.Collection;
using RealWordClienteGenerics.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWordClienteGenerics.Concrete
{
    public class ConcreteAggregate<T> : IAbstractAggregate
        where T : class
        
    {
        List<T> items = new List<T>();
        public ConcreteIterator CreateIterator(this T)
        {
            return new ConcreteIterator(T);
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
