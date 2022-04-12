using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandConceptual.Receptores
{
    /// <summary>
    /// A classe Destinatária contém a lógica do negócio. Quase qualquer objeto pode servir como um destinatário. 
    /// A maioria dos comandos apenas lida com os detalhes de como um pedido é passado para o destinatário,
    /// enquanto que o destinatário em si executa o verdadeiro trabalho.
    /// </summary>
    internal class Receptor
    {
        public void DoSomething(string a)
        {
            Console.WriteLine($"Receiver: Working on ({a}.)");
        }

        public void DoSomethingElse(string b)
        {
            Console.WriteLine($"Receiver: Also working on ({b}.)");
        }
    }
}
