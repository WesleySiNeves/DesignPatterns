using SendMensagens.Interface;
using System;

namespace SendMensagens.Concrect
{
    public class Notifier : INotifier
    {
        public string send(string mensagem)
        {
            var texto  = "###############";

            texto += "\n" + mensagem;

            Console.WriteLine("Enviar por email");
            return texto;
        }
    }
}
