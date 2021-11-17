using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoFactoryMethod.ConcreteProduct
{
    //Product Concrete
    public class PizzaCalabresaRJ : IProduct.Pizza
    {
        public PizzaCalabresaRJ()
        {
            Nome = "Pizza de Calabresa carioca";
            Massa = "Massa um pouco mais grossa";
            Molho = "Molho de tomates italiano com Óregano";
            ingredientes.Add("Queijo Mussarela");
            ingredientes.Add("Rodelas de Calabresa");
            ingredientes.Add("Cebolas caramelizadas");


        }
    }
}
