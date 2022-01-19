using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_DemoCircleNoPadrao
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

        private int x = 10;
        private int y = 30;



        private int raio = 30;


    

        public void SetCor(string cor)
        {
            Cor = cor;


        }

        public void Desenhar()
        {
            Console.WriteLine($"Circulo :Desenhar() [Cor {Cor} x:{x} , y:{y}, raio: {raio}]");
        }
    }
}
