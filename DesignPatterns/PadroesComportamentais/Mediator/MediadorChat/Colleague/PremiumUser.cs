using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediadorChat.Mediator;

namespace MediadorChat.Colleague
{
    internal class PremiumUser : IUser
    {
        string name;
        IChatMediator chatMediator;

        public PremiumUser(IChatMediator chatMediator, string name)
        {
            this.name = name;
            this.chatMediator = chatMediator;

        }
        public void SendMessage(string message)
        {
            Console.WriteLine("User  -- " + name + "; enviando mensagem: " + message);
            chatMediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine("User Type: Preminum -- " + name + "; received message: " + message);
        }
    }
}
