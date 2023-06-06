using AdapterExample.Interfaces;
using Newtonsoft.Json;
using System.Xml;

namespace AdapterExample
{
    public class LumiaXmlAdapter : ILumiaXmlTarget
    {
        public XmlDocument GetLumiaMobilesXmlSpecifications()
        {
            LumiaJsonAdaptee lumiaJsonAdaptee = new LumiaJsonAdaptee();
            string jsonLumia = lumiaJsonAdaptee.GetLumiaMobilesJsonSpecifications();
            var doc = JsonConvert.DeserializeXmlNode(jsonLumia, "MicrosoftLumiaMobiles", true);
            return doc;
        }
    }
}
