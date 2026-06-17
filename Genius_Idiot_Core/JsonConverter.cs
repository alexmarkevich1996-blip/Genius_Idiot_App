using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genius_Idiot_Core
{
    public class JsonConverter : IConvert
    {
        public string Serialize<T>(T item)
        {
            return JsonConvert.SerializeObject(item, Formatting.Indented);
        }
        public T Deserialize<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data)!;
        }

        
    }
}
