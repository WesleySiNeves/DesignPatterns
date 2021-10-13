using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoFactoryMethod.ConcreteProduct
{
    //Product Concrete
    public class PizzaCalabresaSP : IProduct.Pizza
    {
        public PizzaCalabresaSP()
        {
            Nome = "Pizza de Calabresa paulista";
            Massa = "Massa muito fina";
            Molho = "Molho de tomates italiano a moda paulista";
            ingredientes.Add("Queijo Mussarela");
            ingredientes.Add("Rodelas de Calabresa");
            ingredientes.Add("Fatias de Bacon");

        }
    }
}
