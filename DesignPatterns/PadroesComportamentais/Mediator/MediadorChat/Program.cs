using MediadorChat.Colleague;
using MediadorChat.Mediator;

IChatMediator chatMediator = new ChatMediator();



// create users and add them to chat mediator's user list
IUser john = new BasicUser(chatMediator, "John");
IUser tina = new PremiumUser(chatMediator, "Tina");
IUser lara = new PremiumUser(chatMediator, "Lara");

chatMediator.AddUser(john);
chatMediator.AddUser(tina);
chatMediator.AddUser(lara);

// send message
lara.SendMessage("Hello Everyone!");

Console.ReadLine();