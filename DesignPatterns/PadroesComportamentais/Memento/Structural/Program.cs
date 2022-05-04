using Structural;



Originator originator = new Originator();

originator.State = "On";



// Armazena o estado interno
//E ele que faz a quarda e o controle
Caretaker caretaker = new Caretaker();

caretaker.Memento = originator.Snapshot();


// Continue changing originator
originator.State = "Off";

// Restore saved state
originator.Restore(caretaker.Memento);
// Wait for user
Console.ReadKey();