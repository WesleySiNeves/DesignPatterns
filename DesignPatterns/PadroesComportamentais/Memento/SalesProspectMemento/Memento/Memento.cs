using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudanteMemento;

namespace SalesProspectMemento.Memento
{
    public class Memento
    {
        private Guid _idEstudante;
        private string _nome;
        private Int16 _idade;
        private string _telefone;
        private TipoCurso _curso;
        private double _nota;
       
        

       

        // Constructor
        public Memento(Guid idEstudante,string nome, Int16 _idade, string telefone, TipoCurso curso, double nota)
        {
            this.IdEstudante = idEstudante;
            this._nome = nome;
            this._idade = _idade;
            this._telefone = telefone;
            this._curso = curso;
            this._nota = nota;
        }

        public Guid IdEstudante
        {
            get { return _idEstudante; }
            set { _idEstudante = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public Int16 Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        public TipoCurso Curso
        {
            get { return _curso; }
            set { _curso = value; }
        }

        public double Nota
        {
            get { return _nota; }
            set { _nota = value; }
        }

    }
}
