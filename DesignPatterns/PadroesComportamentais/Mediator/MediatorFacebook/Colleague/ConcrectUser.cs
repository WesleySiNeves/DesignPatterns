using MediatorFacebook.Colleague;
using MediatorFacebook.Madiator;


namespace MediatorFacebook.Colleague;

/// <summary>
/// ConcrectColleague
/// </summary>
public class ConcrectUser: User
{
    public ConcrectUser(IFacebookGroupMediator mediator, string name) 
        : base(mediator, name)
    {
    }

    public override void Receive(string mensagem)
    {
        Console.WriteLine($"{name}: recebida => {mensagem}\n");
       
    }

    public override void Send(string mensagem)
    {
        Console.WriteLine($"{name}: enviada <== {mensagem}\n");
        mediator.SendMensage(mensagem, this);
    }

   
}