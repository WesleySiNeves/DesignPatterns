using Structural.ConcrectColleague;
using Structural.Concrete;

ConcreteMediator mediator = new ConcreteMediator();


ConcreteColleague1 wesley = new ConcreteColleague1(mediator);


ConcreteColleague2 dilson = new ConcreteColleague2(mediator);


mediator.Colleague1 = wesley;
mediator.Colleague2 = dilson;
wesley.Send(" Bom dia, como vc está ?");
dilson.Send("Bem, obrigado");
// Wait for user
Console.ReadKey();