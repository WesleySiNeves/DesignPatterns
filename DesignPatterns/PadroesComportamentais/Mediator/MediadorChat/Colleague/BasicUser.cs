using MediadorChat.Mediator;

namespace MediadorChat.Colleague
{
    internal class BasicUser : IUser
    {
        string name;
        IChatMediator chatMediator;

        public BasicUser(IChatMediator chatMediator, string name)
        {
            this.name = name;
            this.chatMediator = chatMediator;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine("User Type: Basic -- " + name + "; received message: " + message);
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("User  -- " + name + "; enviando mensagem: " + message);
            chatMediator.SendMessage(message, this);
        }
    }
}
