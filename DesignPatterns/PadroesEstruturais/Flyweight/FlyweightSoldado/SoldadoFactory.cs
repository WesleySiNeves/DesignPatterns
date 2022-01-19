using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightSoldado
{
    public class SoldadoFactory
    {
        private static Dictionary<string, Soldado> SoldierCollection = new Dictionary<string, Soldado>();
        public SoldadoFactory()
        {
            SoldierCollection = new Dictionary<string, Soldado>();

        }

        public  static  Soldado GetSoldier(TipoSoldado SoldierKey)

        {
            string tipo = ((int)SoldierKey).ToString();

            if (!SoldierCollection.ContainsKey(tipo))

            {
                Console.WriteLine("Soldado Criado");

                switch (SoldierKey)
                {       
                    case TipoSoldado.Arma:
                        SoldierCollection.Add(tipo, new SoldadoArmado());
                        break;
                    case TipoSoldado.Espada:
                        SoldierCollection.Add(tipo, new SoldadoEspada());
                        break;
                    case TipoSoldado.Lanca:
                        SoldierCollection.Add(tipo, new SoldadoLanca());
                        break;
                    case TipoSoldado.PowerRanger:
                        SoldierCollection.Add(tipo, new SoldadoPowerRanger());
                        break;
                    default:
                        break;
                }
                
            }

            else
            {
                Console.WriteLine("Soldado Reutilizado");
            }

            return SoldierCollection[tipo];

        }


        public static int GetTotalItens()
        {
            return SoldierCollection.Count;
        }

        public static void Clear()
        {
            SoldierCollection.Clear();
        }
    }
}
