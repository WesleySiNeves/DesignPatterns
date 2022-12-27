

using NotificacaoEstoque.Observer;
using NotificacaoEstoque.Subject;

ConcreteSuject IPhone  = new ConcreteSuject("IPhone 11",4900,"Sem estoque");
Console.WriteLine($"IPhone 11 - estado atual :{IPhone.GetDisponibilidade()} ");


Console.WriteLine($"Observer inscritos :{IPhone.GetDisponibilidade()} ");


ConcrectObserver cliente1 = new ConcrectObserver("Huguinho", IPhone);

ConcrectObserver cliente2 = new ConcrectObserver("Zezinho", IPhone);

ConcrectObserver cliente3 = new ConcrectObserver("Luisinho", IPhone);


// Alteração da disponibilidade

IPhone.SetDisponibilidade("Disponivel");


IPhone.RemoverObserver(cliente3);
IPhone.RemoverObserver(cliente2);

IPhone.SetDisponibilidade("Disponivel");

Console.ReadKey();

