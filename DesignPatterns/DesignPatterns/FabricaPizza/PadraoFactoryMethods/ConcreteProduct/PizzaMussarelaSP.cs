using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoFactoryMethod.ConcreteProduct
{
    //Product Concrete
    public class PizzaMussarelaSP : IProduct.Pizza
    {
        public PizzaMussarelaSP()
        {
            Nome = "Pizza de mussarela paulista";
            Massa = "Massa muito fina";
            Molho = "Molho de tomates italiano a moda paulista";
            ingredientes.Add("Queijo Mussarela");
            ingredientes.Add("Queijo Parmessão");
            ingredientes.Add("Folhas de Orégano");

        }
    }
}
