using Conceptual.Interface;
using System;

namespace Conceptual.Cliente
{
    public class Client
    {

        // O código do cliente funciona com todos os objetos que usam a interface do componente.
        // Desta forma, ele pode permanecer independente das classes concretas de
        // componentes com os quais trabalha.
        public void ClientCode(Component component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}
