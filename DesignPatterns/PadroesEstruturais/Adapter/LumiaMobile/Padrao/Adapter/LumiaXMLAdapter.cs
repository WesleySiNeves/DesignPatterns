using Newtonsoft.Json;
using Padrao.Adapter.Target;
using System;
using System.Xml;

namespace Padrao.Adapter
{
    public class LumiaXMLAdapter : ILumiaXMLTarget
    {

        public XmlDocument GetLumiaMobileXMLSpecifications()
        {
            LumiaJSONAdaptee lumiaJSONAdaptee = new LumiaJSONAdaptee();

            string json = lumiaJSONAdaptee.GetLumiaMobilesJsonSpecifications();

            var nodes = JsonConvert.DeserializeXmlNode(json, "LumiaMobiles", true);


            return nodes;
        }
    }
}
