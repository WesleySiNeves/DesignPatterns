using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightSoldadoSemPadrao
{
    public class SoldadoLanca : Soldado
    {
        public SoldadoLanca()
        {
            this.Tipo = TipoSoldado.Lanca;
        }
        public override void RenderSoldado(string StrPriName, string Color)
        {
            Console.WriteLine($"Soldado Armado  com {Tipo.ToString()}  com nome:  { StrPriName}  Rendered with na cor  {Color}");
        }
    }
}
