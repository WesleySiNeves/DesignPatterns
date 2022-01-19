using Conceptual.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptual.Business
{
    /// <summary>
    /// define a classe real que o proxy está representando
    /// </summary>
    class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
