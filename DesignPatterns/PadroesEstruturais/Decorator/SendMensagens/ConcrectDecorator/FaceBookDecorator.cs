using SendMensagens.Decorator;
using SendMensagens.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SendMensagens.ConcrectDecorator
{
    public class FaceBookDecorator : SendNotifierBaseDecorator
    {
        public FaceBookDecorator(INotifier n) 
            : base(n)
        {

        }
        public override string send(string mensagem)
        {
            var _mensagem = base.send(mensagem);

            _mensagem = $"mensagem enviada pelo Facebook:\n {mensagem}";

            Console.WriteLine(_mensagem);


            return _mensagem;
        }
    }
}
