using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightSoldado
{
    public class SoldadoArmado : Soldado
    {
        /// <summary>
        /// Create a Concrete Flyweight
        /// </summary>
        public SoldadoArmado()
        {
            this.Tipo = TipoSoldado.Arma;
        }
        public override void RenderSoldado(string StrPriName, string Color)
        {
            Console.WriteLine($"Soldado Armado  com {Tipo.ToString()}  com nome:  { StrPriName}  Rendered with na cor  {Color}");
        }
    }

   


   

    
}
