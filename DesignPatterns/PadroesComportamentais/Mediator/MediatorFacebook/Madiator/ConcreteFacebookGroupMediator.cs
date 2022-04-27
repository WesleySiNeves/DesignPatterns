using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorFacebook.Colleague;
using MediatorFacebook.Madiator;


namespace MediatorFacebook.Madiator
{
    public class ConcreteFacebookGroupMediator : IFacebookGroupMediator
    {
        private List<User> usersList = new List<User>();

        public void Registrer(User user)
        {
            usersList.Add((user));
        }

        public void SendMensage(string mensagen, User user)
        {
            foreach (var item  in usersList)
            {

                //Mensagem não sera recebida para quem está enviando 
                if (item != user)
                {
                    item.Receive(mensagen);

                }
            }
        }

    }
}
