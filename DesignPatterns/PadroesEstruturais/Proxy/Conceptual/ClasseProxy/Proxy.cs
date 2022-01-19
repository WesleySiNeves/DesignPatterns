using Conceptual.Business;
using Conceptual.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptual.ClasseProxy
{
    /// <summary>
    /// Mantem um referencia que permite ao Proxy acessar  RealSubject
    /// </summary>
    class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            this._realSubject = realSubject;
        }


        public void Request()
        {
            if (this.CheckAccess())
            {
                this._realSubject.Request();

                this.LogAccess();
            }
        }

        public bool CheckAccess()
        {
            // Some real checks should go here.
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");

            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}
