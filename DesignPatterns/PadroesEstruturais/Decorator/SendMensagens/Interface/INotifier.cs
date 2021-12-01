using System;
using System.Collections.Generic;
using System.Text;

namespace SendMensagens.Interface
{
    public interface INotifier
    {
        string send(string mensagem);
    }
}
