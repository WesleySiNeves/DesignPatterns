using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediadorChat.Colleague;

namespace MediadorChat.Mediator
{
    public class ChatMediator : IChatMediator
    {
        List<IUser> users;

        public ChatMediator()
        {
            users = new List<IUser>();
        }

        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, IUser sender)
        {
            foreach (IUser user in users)
            {
                // Sender will not receive the message
                if (user != sender)
                    user.ReceiveMessage(message);
            }
        }
    }
    
}
