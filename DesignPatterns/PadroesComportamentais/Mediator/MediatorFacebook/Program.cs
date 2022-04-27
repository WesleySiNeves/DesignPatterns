

using MediatorFacebook.Colleague;

using MediatorFacebook.Madiator;

IFacebookGroupMediator facebookGroupMediator = new ConcreteFacebookGroupMediator();

User wesley = new ConcrectUser(facebookGroupMediator,"Wesley");
User penihel = new ConcrectUser(facebookGroupMediator, "Penihel");
User dilson = new ConcrectUser(facebookGroupMediator, "Dilson");



facebookGroupMediator.Registrer(wesley);
facebookGroupMediator.Registrer(penihel);
facebookGroupMediator.Registrer(dilson);


wesley.Send("Estamos apresentando uma série de videos  sobre Padrões de projetos GOF");
penihel.Send("Onde posso encontar esses Videos ?");
wesley.Send("Veja os videos postados  no canal  da quarta tunada");

