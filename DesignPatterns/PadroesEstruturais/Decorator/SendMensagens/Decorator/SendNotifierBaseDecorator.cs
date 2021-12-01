using SendMensagens.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SendMensagens.Decorator
{

    public class SendNotifierBaseDecorator : INotifier
    {

        private readonly INotifier _notifier;


        public SendNotifierBaseDecorator(INotifier n)
        {

            _notifier = n;

        }
        public virtual string send(string mensagem)
        {
            var _mensagem = _notifier.send(mensagem);

            return _mensagem;
        }
    }
}
