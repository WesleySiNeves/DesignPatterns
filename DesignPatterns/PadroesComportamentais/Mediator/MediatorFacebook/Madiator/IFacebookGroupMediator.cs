using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorFacebook.Colleague;

namespace MediatorFacebook.Madiator
{
    // Mediator interface
    public interface IFacebookGroupMediator
    {
        void Registrer(User user);

        void SendMensage(string mensagen, User user);
        

    }
}
