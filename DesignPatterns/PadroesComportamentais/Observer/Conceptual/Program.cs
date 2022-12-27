// The client code.
using Conceptual.Concrect;


var subject = new Conceptual.Subject.Subject();

var observerA = new ConcreteObserverA();
subject.Attach(observerA);

var observerB = new ConcreteObserverB();

subject.Attach(observerB);


subject.SomeBusinessLogic();

subject.SomeBusinessLogic();


subject.Detach(observerB);

subject.SomeBusinessLogic();