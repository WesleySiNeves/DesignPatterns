// The client code may or may not know about the Concrete Iterator
// or Collection classes, depending on the level of indirection you
// want to keep in your program.
using Conceptual.Collection;

var collection = new ConcreteAggregate();
collection.AddItem("First");
collection.AddItem("Second");
collection.AddItem("Third");

Console.WriteLine("Straight traversal:");


/// <summary>
/// Aqui  ele passa pelo método  GetEnumerator do meu ConcreteAggregate
/// Ao passar pelo In ele chega no MoveNext do meu  ConcreteIterator
/// Depois ele passa pelo Current  do meu ConcreteIterator
/// </summary>
foreach (var element in collection)
{
    Console.WriteLine(element);
}

Console.WriteLine("\nReverse traversal:");

collection.ReverseDirection();

foreach (var element in collection)
{
    Console.WriteLine(element);
}


