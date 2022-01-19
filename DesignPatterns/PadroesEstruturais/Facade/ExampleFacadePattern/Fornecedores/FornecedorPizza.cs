using ExampleFacadePattern.Interfaces;
using System;

namespace ExampleFacadePattern.Fornecedores
{
    public class FornecedorPizza : IPizza
    {
        public void BuscarPizzaNormal()
        {
            ObterCoberturaNaoVegana();
            Console.WriteLine("Obtendo coberturas de pizzas não vegetais");
        }

        public void BuscarPizzaVegana()
        {
            Console.WriteLine("Buscando Pizzas Veganas");
        }

        private void ObterCoberturaNaoVegana()
        {
            Console.WriteLine("Obtendo coberturas de pizzas não vegetais");
        }
    }
}
