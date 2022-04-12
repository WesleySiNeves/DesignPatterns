using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraAppConsole.Commands;
using CalculadoraAppConsole.Interface;
using CalculadoraAppConsole.Invoker;
using CalculadoraAppConsole.Receiver;

namespace CalculadoraAppConsoleConsole
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            //Inicialize o Invoker


            User user = new User();


            // User presses calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);
            // Undo 4 commands
            user.Desfazer(4);
            // Redo 3 commands
            user.Refazer(3);
            // Wait for user
            Console.ReadKey();
        }
    }
}
