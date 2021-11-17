using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaCarrosUI.Util
{
    public class RandonUtil
    {

        public static int GetRandonInt(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);

        }

        public static string GetRandonString(List<string> lista)
        {
            Random random = new Random();
            var index = random.Next(0, lista.Count);

            return lista[index];

        }
    }
}
