using SendMensagens.Decorator;
using SendMensagens.Interface;
using System;

namespace SendMensagens.ConcrectDecorator
{
    public class SMSDecorator : SendNotifierBaseDecorator
    {
        public SMSDecorator(INotifier n)
            : base(n)
        {

        }
        public override string send(string mensagem)
        {
            var _mensagem = base.send(mensagem);

            _mensagem = $"mensagem enviada pelo SMS:\n {mensagem}";

            Console.WriteLine(_mensagem);

            return _mensagem;
        }
    }
}
