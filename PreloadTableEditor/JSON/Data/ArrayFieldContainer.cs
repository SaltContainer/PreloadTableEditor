using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreloadTableEditor.JSON.Data
{
    public class ArrayFieldContainer
    {
        [JsonProperty(PropertyName = "first")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "second")]
        public AssetInfo Info { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
