using RealWorldCliente.Collection;

namespace RealWorldCliente.Interface
{
    public interface IAbstractIterator
    {
        Cliente First();
        Cliente Next();
        bool IsDone { get; }
        Cliente CurrentItem { get; }
    }
}
