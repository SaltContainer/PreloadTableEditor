using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreloadTableEditor.JSON.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PreloadTableEditor.JSON.Converters
{
    class ContainerConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Container);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JArray array = JArray.Load(reader);
            return new Container
            {
                Name = (string)array[0],
                Info = (AssetInfo)array[1].ToObject(typeof(AssetInfo))
            };
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Container container = (Container)value;
            writer.WriteStartArray();
            writer.WriteValue(container.Name);
            serializer.Serialize(writer, container.Info);
            writer.WriteEndArray();
        }
    }
}
