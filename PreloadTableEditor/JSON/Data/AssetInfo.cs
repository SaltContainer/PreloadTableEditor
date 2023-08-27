using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreloadTableEditor.JSON.Data
{
    public class AssetInfo
    {
        [JsonProperty(PropertyName = "preloadIndex")]
        public long PreloadIndex { get; set; }

        [JsonProperty(PropertyName = "preloadSize")]
        public long PreloadSize { get; set; }

        [JsonProperty(PropertyName = "asset")]
        public UnityFile Asset { get; set; }
    }
}
