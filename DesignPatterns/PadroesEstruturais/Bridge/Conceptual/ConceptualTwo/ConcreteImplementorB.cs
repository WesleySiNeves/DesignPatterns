using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptualTwo
{
    public class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}
