using RealWordClienteGenerics.Collection;

namespace RealWordClienteGenerics.Interface
{
    public interface IAbstractIterator
    {
        Cliente First();
        Cliente Next();
        bool IsDone { get; }
        Cliente CurrentItem { get; }
    }
}
