using CalculadoraAppConsole.Commands;
using CalculadoraAppConsole.Interface;
using CalculadoraAppConsole.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAppConsole.Invoker
{
    public class User
    {
        // Initializers
        //Receiver
        Calculator calculator = new Calculator();

        //Command

        List<Command> commands = new List<Command>();
        int current = 0;
        public void Refazer(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);
            // Perform redo operations
            for (int i = 0; i < levels; i++)
            {
                if (current < commands.Count - 1)
                {
                    Command command = commands[current++];
                    command.Execute();
                }
            }
        }
        public void Desfazer(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);

            // Perform undo operations
            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    Command command = commands[--current] as Command;
                    command.UnExecute();
                }
            }
        }
        public void Compute(char @operator, int operand)
        {
            // Create command operation and execute it
            Command command = new CalculatorCommand(calculator, @operator, operand);
            command.Execute();
            // Add command to undo list
            commands.Add(command);
            current++;
        }
    }
}
