using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificacaoEstoque.Observer;

namespace NotificacaoEstoque.Subject
{
    public interface ISubject
    {

        void NotificarObservers();
        void RegistrarObserver(IObserver observer);

        void RemoverObserver(IObserver observer);


    }
}
