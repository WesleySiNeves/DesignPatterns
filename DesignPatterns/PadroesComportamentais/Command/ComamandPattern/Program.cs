

using ComamandPattern.Receiver;
using ComamandPattern.Concret;

var receiver = new Receiver();

receiver.Handle(new Command(1, "Comando 1"));