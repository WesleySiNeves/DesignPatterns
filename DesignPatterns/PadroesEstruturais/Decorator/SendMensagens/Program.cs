
using SendMensagens.Concrect;
using SendMensagens.ConcrectDecorator;
using SendMensagens.Interface;
using System;

namespace SendMensagens
{
    class Program
    {
        static void Main(string[] args)
        {
            INotifier notifier = new Notifier();


            notifier.send("Inicio");

            Console.ReadKey();


            INotifier faceBookDecorator = new FaceBookDecorator(notifier);

            faceBookDecorator.send("Boa tarde galera!");

            Console.ReadKey();



            INotifier slackDecorator = new SlackDecorator(faceBookDecorator);

            slackDecorator.send("Esse é um exemplo simples com Decorator!");

            Console.ReadKey();


            INotifier sMSDecorator = new SMSDecorator(slackDecorator);

            sMSDecorator.send("Enviando Mensagem ao cliente!");

            Console.ReadKey();



            /*Passando um Decorator */


            notifier.send("Fim");

            Console.ReadKey();




        }
    }
}
