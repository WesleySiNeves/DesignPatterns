using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightSoldado
{
    public class SoldadoPowerRanger : Soldado
    {
        public SoldadoPowerRanger()
        {
            this.Tipo = TipoSoldado.PowerRanger;
        }
        public override void RenderSoldado(string StrPriName, string Color)
        {
            Console.WriteLine($" { StrPriName} Hora de mofar, chamando o megazord na cor  {Color}");
        }
    }
}
