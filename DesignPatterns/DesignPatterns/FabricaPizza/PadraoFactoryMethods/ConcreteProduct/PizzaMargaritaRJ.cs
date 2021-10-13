using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoFactoryMethod.ConcreteProduct
{
    public class PizzaMargaritaRJ : IProduct.Pizza
    {
        public PizzaMargaritaRJ()
        {
            Nome = "Pizza de Margarita paulista";
            Massa = "Massa muito fina";
            Molho = "Molho de tomates italiano a moda paulista";
            ingredientes.Add("Queijo Mussarela");
            ingredientes.Add("Tomate");
            ingredientes.Add("Rúcula");
        }
    }
}
