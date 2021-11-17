using PadraoAbstractFactory.Factory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoAbstractFactory.Factory.ConcretFactory
{
    public class PizzaFactory : MassaFactory
    {
        public override void AssarMassa()
        {
            Console.WriteLine("Assando massa de pizza");
        }

        public override void CriarMassa()
        {
            Console.WriteLine("Criando massa de pizza");
        }
    }
}
