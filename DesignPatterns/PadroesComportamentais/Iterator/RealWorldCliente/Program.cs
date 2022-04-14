using RealWorldCliente.Collection;
using RealWorldCliente.Concrete;

ConcreteAggregate colecao  = new ConcreteAggregate();


colecao.AddCliente(new Cliente(1, "Cliente A"));
colecao.AddCliente(new Cliente(2, "Cliente B"));
colecao.AddCliente(new Cliente(3, "Cliente C"));
colecao.AddCliente(new Cliente(4, "Cliente D"));
colecao.AddCliente(new Cliente(5, "Cliente E"));
colecao.AddCliente(new Cliente(6, "Cliente F"));
colecao.AddCliente(new Cliente(7, "Cliente G"));
colecao.AddCliente(new Cliente(8, "Cliente H"));


ConcreteIterator iterator = colecao.CreateIterator();



Console.WriteLine("Iteragindo Utilizando o Padrão Iterator");


for (Cliente cliente = iterator.First(); !iterator.IsDone; cliente = iterator.Next())
{
    Console.WriteLine($" ID {cliente.Id} Nome : {cliente.Nome}");

}
