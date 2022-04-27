using TorreAviacao.Colleague;
using TorreAviacao.Mediator;

IControladorVooMediator controladorVooMediator = new ControladorVooMediator();

Aviao aviao007 = new Aviao(controladorVooMediator);

PistaVoo mainPistaVoo = new PistaVoo(controladorVooMediator);

controladorVooMediator.registerAviao(aviao007);
controladorVooMediator.registerPista(mainPistaVoo);
aviao007.prepararParaPousar();
mainPistaVoo.Pousar();
aviao007.Pousar();