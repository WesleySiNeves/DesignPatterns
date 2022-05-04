// Client code.

using CalcMementoGenerateSenhasConsole.Caretaker;
using CalcMementoGenerateSenhasConsole.Originator;


Originator originator = new Originator("Super-super-super-super-super.");
Caretaker caretaker = new Caretaker(originator);

caretaker.Backup();
originator.GerarSenha();

caretaker.Backup();
originator.GerarSenha();

caretaker.Backup();
originator.GerarSenha();

Console.WriteLine();
caretaker.ShowHistory();

Console.WriteLine("\nClient: Now, let's rollback!\n");
caretaker.Undo();

Console.WriteLine("\n\nClient: Once more!\n");
caretaker.Undo();

Console.WriteLine();

Console.WriteLine("\n\nClient: Once more!\n");
caretaker.Undo();

Console.ReadKey();