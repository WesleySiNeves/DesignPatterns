using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_DemoCircle
{
    public  class Circulo : IForma
    {

        /// <summary>
        /// Estado extrinseco
        /// </summary>
        public string Cor { get; set; }


        /// <summary>
        /// Estado intrinseco (cache)
        /// </summary>

        public int X { get; set; }

        public int Y { get; set; }

        public int Raio { get; set; }

        public void SetCor(string cor)
        {
            Cor = cor;


        }

        public void Desenhar()
        {
            Console.WriteLine($"Circulo :Desenhar() [Cor {Cor} x:{X} , y:{Y}, raio: {Raio}]");
        }
    }
}
