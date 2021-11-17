using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptual.ConcretPrototype.DeepCopy
{
    public class Soldado : ICloneable
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public Acessorio Acessorio { get; set; }

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
            Soldado soldado = (Soldado)this.MemberwiseClone();

            soldado.Acessorio = (Acessorio)this.Acessorio.Clone();

            return soldado;
        }
    }
    public class Acessorio : ICloneable
    {
        public string Nome { get; set; }

        public object Clone()
        {
            return (Acessorio)this.MemberwiseClone();
        }
    }
}
