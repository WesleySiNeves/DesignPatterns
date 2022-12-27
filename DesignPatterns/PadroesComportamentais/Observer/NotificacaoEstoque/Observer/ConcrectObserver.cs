using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificacaoEstoque.Subject;

namespace NotificacaoEstoque.Observer
{
    public class ConcrectObserver : IObserver
    {
        public string Usuario { get; set; }

        public ConcrectObserver(string usuario, ISubject subject)
        {
            Usuario = usuario;
            subject.RegistrarObserver(this);


        }
        public void Atualizar(string disponibilidade)
        {

            Console.WriteLine($"Olá Usuario {Usuario} o produto que vc deseja agora está {disponibilidade} em nosso site");
        }
    }
}
