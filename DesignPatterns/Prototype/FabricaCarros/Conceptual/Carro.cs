using System;

namespace Conceptual
{
    public class Carro : Prototype
    {
        public Carro(Guid chassi)
        {
            Chassi = chassi;
        }
        public Carro()
        {

        }
        public string Marca { get; set; }

        public int Ano { get; set; }


        public string Modelo { get; set; }


        //public Motor MotorCarro { get; set; }

        public override Carro DeepCopy()
        {
            var self = new Carro();
            self.Ano = int.Parse(string.Copy(this.Ano.ToString()));
            self.Marca = string.Copy(this.Marca);
            self.Modelo = string.Copy(this.Modelo);

            //if (this.MotorCarro != null)
            //{
            //    self.MotorCarro = new Motor();
            //    self.MotorCarro.Potencia = string.Copy(this.MotorCarro.Potencia);
            //    self.MotorCarro.QuantidadCavalos = int.Parse(string.Copy(this.MotorCarro.QuantidadCavalos.ToString()));
            //}

            return self;
        }

        public override Carro ShallowCopy()
        {
            return (Carro)this.MemberwiseClone();
        }
    }

    public class Motor
    {
        public int QuantidadCavalos { get; set; }

        public string Potencia { get; set; }
    }
}
