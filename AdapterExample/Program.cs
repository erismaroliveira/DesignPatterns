using AdapterExample;
using AdapterExample.Interfaces;

ILumiaXmlTarget lumiaXmlTarget = new LumiaXmlAdapter();
var xmlLumiaMobile = lumiaXmlTarget.GetLumiaMobilesXmlSpecifications();
Console.WriteLine(xmlLumiaMobile.InnerText);