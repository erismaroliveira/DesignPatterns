using AdapterExample.Interfaces;
using AdapterExample.Model;
using Newtonsoft.Json;

namespace AdapterExample
{
    public class LumiaJsonAdaptee : ILumiaJsonAdaptee
    {
        public string GetLumiaMobilesJsonSpecifications()
        {
            List<LumiaMobile> listLumiaMobiles = new List<LumiaMobile>();
            listLumiaMobiles.Add(new LumiaMobile
            {
                ModeloId = "Lumia 550",
                Altura = "136.1mm",
                Largura = "67.8mm",
                Espessura = "9.9mm",
                Peso = "141.9g"
            });
            listLumiaMobiles.Add(new LumiaMobile
            {
                ModeloId = "Lumia 950",
                Altura = "145mm",
                Largura = "73.2mm",
                Espessura = "8.2mm",
                Peso = "150g"
            });
            listLumiaMobiles.Add(new LumiaMobile
            {
                ModeloId = "Text",
                Altura = "",
                Largura = "",
                Espessura = "8.2mm",
                Peso = "150g"
            });
            dynamic collectionLumiaMobiles = new
            {
                lumiaMobiles = listLumiaMobiles
            };
            return JsonConvert.SerializeObject(collectionLumiaMobiles);
        }
    }
}
