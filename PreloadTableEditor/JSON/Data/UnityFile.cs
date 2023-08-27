using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreloadTableEditor.JSON.Data
{
    public class UnityFile
    {
        [JsonProperty(PropertyName = "m_FileID")]
        public long FileID { get; set; }

        [JsonProperty(PropertyName = "m_PathID")]
        public long PathID { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1}", FileID, PathID);
        }
    }
}
