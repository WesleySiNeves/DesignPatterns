using Padrao.Adapter;
using Padrao.Adapter.Target;
using System;

namespace Padrao
{
    class Program
    {
        protected static void Main(string[] args)
        {

            ILumiaXMLTarget lumiaXMLTarget = new LumiaXMLAdapter();

            var xmlDocument = lumiaXMLTarget.GetLumiaMobileXMLSpecifications();

            Console.WriteLine(xmlDocument.InnerText);


            Console.ReadKey();

        }
    }
}
