using Conceptual.ConcretPrototype.Interface;
using System;
using System.Collections.Generic;

namespace Conceptual.ConcretPrototype.ShallowCopy
{
   

    public class Soldado : ICloneable
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }



        public ShallowCopy.Acessorio Acessorio { get; set; }
       

        public Soldado()
        {

        }

        public Soldado(Soldado soldado)
        {

            Id = soldado.Id;
            Nome = soldado.Nome;
            Idade = soldado.Idade;
            Acessorio = soldado.Acessorio;

        }

        public object Clone()
        {
            return new Soldado(this);
        }
    }

    public class Acessorio
    {
        public string Nome { get; set; }

    }

}
