using CommandConceptual.Interface;
using System;

namespace CommandConceptual.Remetente
{

    /// <summary>
    /// A classe Remetente (também conhecida como invocadora) é responsável por iniciar os pedidos.
    /// Essa classe deve ter um campo para armazenar a referência para um objeto comando.
    /// O remetente aciona aquele comando ao invés de enviar o pedido diretamente para o destinatário.
    /// Observe que o remetente não é responsável por criar o objeto comando.
    /// Geralmente ele é pré criado através de um construtor do cliente.
    /// </summary>
    public class Invoker
    {
        private ICommand _onStart;

        private ICommand _onFinish;

        // Initialize commands.
        public void SetOnStart(ICommand command)
        {
            this._onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            this._onFinish = command;
        }

        // The Invoker does not depend on concrete command or receiver classes.
        // The Invoker passes a request to a receiver indirectly, by executing a
        // command.
        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");
            if (this._onStart is ICommand)
            {
                this._onStart.Execute();
            }

            Console.WriteLine("Invoker: ...doing something really important...");

            Console.WriteLine("Invoker: Does anybody want something done after I finish?");
            if (this._onFinish is ICommand)
            {
                this._onFinish.Execute();
            }
        }
    }
}
