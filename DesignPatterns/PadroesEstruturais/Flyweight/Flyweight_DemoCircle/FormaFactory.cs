using Flyweight_DemoCircle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_DemoCirclePadrao
{
    public class FormaFactory : IForma
    {
        private static Dictionary<string, IForma> formas = new Dictionary<string, IForma>();


        public static IForma GetForma(string chave)
        {

            IForma forma;

            if (formas.ContainsKey(chave))
            {
                return formas[chave];
            }
            else
            {
                if (chave == "circulo")
                {
                    forma = new Circulo();
                    formas.Add(chave, forma);

                }
                else
                {
                    throw new Exception("Esse tipo de objeto não pode ser criado");
                }

            }

            return forma;

        }

        public void Desenhar()
        {
           
        }

        public static int  GetTotalItens()
        {
            return formas.Count;
        }
    }
}
