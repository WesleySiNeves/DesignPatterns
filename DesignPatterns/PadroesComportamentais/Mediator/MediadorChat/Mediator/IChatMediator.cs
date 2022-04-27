using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediadorChat.Colleague;

namespace MediadorChat.Mediator
{

    // Mediator interface
    public interface IChatMediator
    {
        void AddUser(IUser user);
        void SendMessage(string message, IUser sender);
    }
}
