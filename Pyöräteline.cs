using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Luokkakaavio
{
    public class Pyöräteline
    {
        public List<Polkupyora> polkupyorat = new List<Polkupyora>();
        private int maxLkm = 5;
        static string fillaritTiedosto = @"fillarit.json";

        public bool parkkeeraa( Polkupyora fillari )
        {
            if (!onTilaa())
                return false;

            polkupyorat.Add( fillari );

            return true;
        }

        private bool onTilaa()
        {
            return polkupyorat.Count < maxLkm;
        }

        public void tallennaFillarit()
        {
            //https://stackoverflow.com/questions/46057081/json-newtonsoft-c-sharp-deserialize-list-of-objects-of-different-types
            KnownTypesBinder loKnownTypesBinder = new KnownTypesBinder()
            {
                KnownTypes = new List<Type> { typeof(Polkupyora) }
            };

            IEnumerable<Polkupyora> Data = polkupyorat.AsEnumerable();

            JsonSerializerSettings loJsonSerializerSettings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Objects,
                SerializationBinder = loKnownTypesBinder,
                Formatting = Formatting.Indented
            };

            String json = JsonConvert.SerializeObject(Data, loJsonSerializerSettings);
            File.WriteAllText(fillaritTiedosto, json);
        }

        public void lataaFillarit()
        {
            if (new FileInfo(fillaritTiedosto).Length == 0)
                return;

            KnownTypesBinder loKnownTypesBinder = new KnownTypesBinder()
            {
                KnownTypes = new List<Type> { typeof(Polkupyora) }
            };

            JsonSerializerSettings loJsonSerializerSettings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Objects,
                SerializationBinder = loKnownTypesBinder,
                Formatting = Formatting.Indented
            };

            polkupyorat = JsonConvert.DeserializeObject<List<Polkupyora>>(File.ReadAllText(fillaritTiedosto), loJsonSerializerSettings);

            if( polkupyorat.Count > maxLkm)
                polkupyorat.RemoveRange(maxLkm, polkupyorat.Count-maxLkm );
        }
    }
}