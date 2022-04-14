using RealWordClienteGenerics.Collection;
using RealWordClienteGenerics.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWordClienteGenerics.Concrete
{
    public class ConcreteIterator<T> : IAbstractIterator
    {
        ConcreteAggregate collection;
        int current = 0;
        int step = 1;
        // Constructor
        public ConcreteIterator(ConcreteAggregate T)
        {
            this.collection = collection;
        }
        // Gets first item
        public Cliente First()
        {
            current = 0;
            return collection.GetCliente(current) as T;
        }

        // Gets next item
        public Cliente Next()
        {
            current += step;
            if (!IsDone)
                return collection.GetCliente(current) as T;
            else
                return null;
        }
        // Gets or sets stepsize
        public int Step
        {
            get { return step; }
            set { step = value; }
        }
        // Gets current iterator item
        public Cliente CurrentItem
        {
            get { return collection.GetCliente(current) as T; }
        }
        // Gets whether iteration is complete
        public bool IsDone
        {
            get { return current >= collection.Count; }
        }
    }
}
