using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaCarrosUI.Conceitual
{
    public class Carro : Prototype
    {
        public Carro(Guid chassi)
        {
            Chassi = chassi;
        }
        public string Marca { get; set; }

        public int Ano { get; set; }


        public string Modelo { get; set; }

        public override Carro DeepCopy()
        {
            return (Carro)this.MemberwiseClone();
        }

        public override Carro ShallowCopy()
        {
            return (Carro)this.MemberwiseClone();
        }
    }
}
