using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificacaoEstoque.Observer;

namespace NotificacaoEstoque.Subject
{
    internal class ConcreteSuject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        protected string Produto { get; set; }
        protected decimal Preco { get; set; }

        protected string Disponibilidade { get; set; }



        public ConcreteSuject(string produto, decimal preco, string disponibilidade)
        {
            Produto = produto;
            Preco = preco;
            Disponibilidade = disponibilidade;


        }
       

       

        public string GetDisponibilidade()
        {
            return Disponibilidade;
        }

        public void SetDisponibilidade(string status)
        {
            Console.WriteLine($"A disponibilidade mudou de {Disponibilidade} para {status}");
            Disponibilidade = status;
            NotificarObservers();

        }

        public void RegistrarObserver(IObserver observer)
        {
            Console.WriteLine($"Observer adicionado {((ConcrectObserver)observer).Usuario} ");
            observers.Add(observer);

        }
        public void AdicionarObserver(IObserver observer)
        {
            observers.Add(observer);

        }

        public void RemoverObserver(IObserver observer)
        {
            observers.Remove(observer);

        }

        public void NotificarObservers()
        {
            Console.WriteLine($"O produto: {Produto}   no valor de R$ {Preco} ");
            Console.WriteLine($"Notificando todos os inscritos");

            foreach (var observer in observers)
            {
                observer.Atualizar(Disponibilidade);
            }

        }
    }
}
