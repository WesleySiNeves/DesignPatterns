using CommandConceptual.Interface;
using CommandConceptual.Receptores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandConceptual.Commands
{
    /// <summary>
    /// Comandos Concretos implementam vários tipos de pedidos.
    /// Um comando concreto não deve realizar o trabalho por conta própria, 
    /// mas passar a chamada para um dos objetos da lógica do negócio.
    /// Contudo, para simplificar o código, essas classes podem ser fundidas.
    /// </summary>
    internal class ComplexCommand : ICommand
    {
        private Receptor _receiver;

        private string _a;

        private string _b;

        public ComplexCommand(Receptor receiver, string a, string b)
        {
            this._receiver = receiver;
            this._a = a;
            this._b = b;

        }

        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            this._receiver.DoSomething(this._a);
            this._receiver.DoSomethingElse(this._b);
        }
    }
}
