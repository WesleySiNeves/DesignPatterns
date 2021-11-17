using Newtonsoft.Json;
using Padrao.Interfaces;
using Padrao.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao
{
    public class LumiaJSONAdaptee : ILumiaJSONAdaptee
    {
        public string GetLumiaMobilesJsonSpecifications()
        {

            List<LumiaMobile> mobiles = new List<LumiaMobile>();

            mobiles.Add(new LumiaMobile
            {
                IdModelo = "lumia550",
                Altura = "134 mm",
                Espessura = "14 mm",
                Largura = "64 mm",
                Peso = "141 g"
            });

            mobiles.Add(new LumiaMobile
            {
                IdModelo = "lumia650",
                Altura = "139 mm",
                Espessura = "10 mm",
                Largura = "80 mm",
                Peso = "120 g"
            });


            mobiles.Add(new LumiaMobile
            {
                IdModelo = "lumia750",
                Altura = "150 mm",
                Espessura = "09 mm",
                Largura = "80 mm",
                Peso = "90 g"
            });




            dynamic collections = new
            {
                LumiaMObile = mobiles

            };

            return JsonConvert.SerializeObject(collections);
        }
    }
}
