using DemoPizza.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPizza.Concrect
{
    public class Pizza : IPizza
    {
        public string BuscarTipoPizza()
        {
            var pizza = "Essa é uma pizza Normal";

            return pizza;
        }
    }
}
