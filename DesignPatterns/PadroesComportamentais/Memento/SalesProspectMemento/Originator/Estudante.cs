using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudanteMemento;

namespace SalesProspectMemento.Originator
{
    public class Estudante
    {
        private Guid _idEstudante;
        string _nome;
        private Int16 _idade;
        private TipoCurso _curso;
        string _telefone;
        double _nota;


        #region Get/ Set

        public Guid IdEstudante
        {
            get { return _idEstudante; }
            set
            {
                _idEstudante = value;
                Console.WriteLine("IdEstudante: " + _idEstudante);
            }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                Console.WriteLine("Nome:   " + _nome);
            }
        }

        public Int16 Idade
        {
            get { return _idade; }
            set
            {
                _idade = value;
                Console.WriteLine("Idade:   " + _idade);
            }
        }


        public TipoCurso Curso
        {
            get { return _curso; }
            set
            {
                _curso = value;
                Console.WriteLine("Curso:  " + _curso);
            }
        }

        public double Nota
        {
            get { return _nota; }
            set
            {
                _nota = value;
                Console.WriteLine("Nota: " + _nota);
            }
        }



        public string Telefone
        {
            get { return _telefone; }
            set
            {
                _telefone = value;
                Console.WriteLine("Telefone:  " + _telefone);
            }
        }


        #endregion

        #region  Memento


        // Stores memento
        public Memento.Memento CreateMemento()
        {
            Console.WriteLine("\nSalva o estado do objeto --\n");
            return new Memento.Memento(_idEstudante,_nome,_idade, _telefone,_curso,_nota);
        }

        // Restores memento
        public void GetMemento(Memento.Memento memento)
        {

            Console.WriteLine("\nRestaura o estado anterior --\n");
            IdEstudante  = memento.IdEstudante; 
            Nome = memento.Nome;
            Idade = memento.Idade;
            Curso = memento.Curso;
            Nota = memento.Nota;
            Telefone = memento.Telefone;
            

        }

        #endregion

    }
}
