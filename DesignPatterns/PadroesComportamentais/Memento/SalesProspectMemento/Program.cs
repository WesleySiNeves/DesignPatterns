using EstudanteMemento;
using SalesProspectMemento.Caretaker;
using SalesProspectMemento.Originator;

Estudante estudante = new Estudante();


estudante.IdEstudante = Guid.NewGuid();
estudante.Nome = "Maria";
estudante.Idade = 13;
estudante.Curso = TipoCurso.Quimica;
estudante.Nota = 8;
estudante.Telefone = "(412) 256-0990";



// Store internal state
Caretaker m = new Caretaker();

m.Memento = estudante.CreateMemento();


// Continue changing originator
estudante.Idade = 14;
estudante.Curso = TipoCurso.Matematica;
estudante.Nota = 9;


// Restore saved state
estudante.GetMemento(m.Memento);

// Wait for user
Console.ReadKey();