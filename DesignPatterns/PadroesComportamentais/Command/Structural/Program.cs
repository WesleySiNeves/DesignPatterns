// Create receiver, command, and invoker
using Structural.Commands;
using Structural.Interface;
using Structural.Receptores;
using Structural.Remetente;


//Receiver
Receiver receiver = new Receiver();


//Command
Command command = new ConcreteCommand(receiver);


//Invoker
Invoker invoker = new Invoker();

// Set and execute command
invoker.SetCommand(command);


invoker.ExecuteCommand();
// Wait for user
Console.ReadKey();