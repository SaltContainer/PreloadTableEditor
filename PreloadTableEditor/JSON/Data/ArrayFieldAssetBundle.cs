using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreloadTableEditor.JSON.Data
{
    public class ArrayFieldAssetBundle
    {
        [JsonProperty(PropertyName = "m_Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "m_PreloadTable")]
        public ArrayContainer<UnityFile> PreloadTable { get; set; }

        [JsonProperty(PropertyName = "m_Container")]
        public ArrayContainer<ArrayFieldContainer> Container { get; set; }

        [JsonProperty(PropertyName = "m_MainAsset")]
        public AssetInfo MainAsset { get; set; }

        [JsonProperty(PropertyName = "m_RuntimeCompatibility")]
        public long RuntimeCompatibility { get; set; }

        [JsonProperty(PropertyName = "m_AssetBundleName")]
        public string AssetBundleName { get; set; }

        [JsonProperty(PropertyName = "m_Dependencies")]
        public ArrayContainer<string> Dependencies { get; set; }

        [JsonProperty(PropertyName = "m_IsStreamedSceneAssetBundle")]
        public bool IsStreamedSceneAssetBundle { get; set; }

        [JsonProperty(PropertyName = "m_ExplicitDataLayout")]
        public long ExplicitDataLayout { get; set; }

        [JsonProperty(PropertyName = "m_PathFlags")]
        public long PathFlags { get; set; }

        [JsonProperty(PropertyName = "m_SceneHashes")]
        public ArrayContainer<string> SceneHashes { get; set; }
    }
}
