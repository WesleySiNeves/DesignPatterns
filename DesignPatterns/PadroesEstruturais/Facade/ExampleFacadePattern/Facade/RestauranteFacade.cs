using ExampleFacadePattern.Fornecedores;
using ExampleFacadePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleFacadePattern.Facade
{
    public class RestauranteFacade
    {
        private IPizza _Fornecedorpizza;
        private IPao _Fornecedorpao;

        public RestauranteFacade()
        {
            _Fornecedorpizza = new FornecedorPizza();
            _Fornecedorpao = new FornecedorPao();
        }


        public void BuscarPizzaNormal()
        {
            _Fornecedorpizza.BuscarPizzaNormal();
        }

        public void BuscarPizzaVegana()
        {

            _Fornecedorpizza.BuscarPizzaVegana();
        }

        public void BuscarPaoAlho()
        {
            _Fornecedorpao.BuscarPaoAlho();
        }

        public void BuscarPaoAlhoComQueijo()
        {
            _Fornecedorpao.BuscarPaoAlhoComQueijo();
        }
    }
}
