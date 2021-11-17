using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoFactoryMethod.ConcreteProduct
{
    //Product Concrete
    public class PizzaMussarelaRJ : IProduct.Pizza
    {
        public PizzaMussarelaRJ()
        {
            Nome = "Pizza de mussarela carioca";
            Massa = "Massa um pouco mais grossa com borda";
            Molho = "Molho de tomates";
            ingredientes.Add("Queijo parmessão");
            ingredientes.Add("Queijo parmessão");
            ingredientes.Add("Ovo cozido fatiado");

        }
    }
}
