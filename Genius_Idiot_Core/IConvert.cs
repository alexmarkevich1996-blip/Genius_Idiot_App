using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genius_Idiot_Core
{
    internal interface IConvert
    {
        public string Serialize<T>(T item);

        public T Deserialize<T>(string data);
    }
}
