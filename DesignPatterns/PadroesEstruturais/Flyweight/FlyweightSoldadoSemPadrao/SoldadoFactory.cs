using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightSoldadoSemPadrao
{
    public class SoldadoFactory
    {
        private static List<Soldado> SoldierCollection = new List<Soldado>();
        public SoldadoFactory()
        {


        }

        public static Soldado GetSoldier(TipoSoldado SoldierKey)
        {
            string tipo = ((int)SoldierKey).ToString();


            Console.WriteLine("Soldado Criado");
            Soldado soldado = new SoldadoArmado();

            switch (SoldierKey)
            {
                case TipoSoldado.Arma:
                    soldado = new SoldadoArmado();
                    SoldierCollection.Add(soldado);
                    break;
                case TipoSoldado.Espada:
                    soldado = new SoldadoEspada();
                    SoldierCollection.Add(soldado);
                    break;
                case TipoSoldado.Lanca:
                    soldado = new SoldadoLanca();
                    SoldierCollection.Add(soldado);
                    break;
                case TipoSoldado.PowerRanger:
                    soldado = new SoldadoPowerRanger();
                    SoldierCollection.Add(soldado);
                    break;
                default:
                    break;
            }

            return soldado;

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
