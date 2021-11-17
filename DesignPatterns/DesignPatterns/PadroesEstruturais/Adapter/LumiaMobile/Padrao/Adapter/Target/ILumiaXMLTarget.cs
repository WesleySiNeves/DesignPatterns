using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Padrao.Adapter.Target
{
    public interface ILumiaXMLTarget
    {
        XmlDocument GetLumiaMobileXMLSpecifications();
    }
}
