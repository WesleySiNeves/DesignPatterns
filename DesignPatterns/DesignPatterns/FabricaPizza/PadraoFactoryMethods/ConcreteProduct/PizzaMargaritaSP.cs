using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoFactoryMethod.ConcreteProduct
{
   public class PizzaMargaritaSP : IProduct.Pizza
    {
        public PizzaMargaritaSP()
        {
            Nome = "Pizza de Margarita paulista";
            Massa = "Massa muito fina";
            Molho = "Molho de tomates italiano a moda paulista";
            ingredientes.Add("Queijo Mussarela");
            ingredientes.Add("Tomate");
            ingredientes.Add("Bacon");

        }
    }
}
