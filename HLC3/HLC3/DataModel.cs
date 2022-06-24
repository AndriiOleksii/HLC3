using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HLC3
{
    public class DataModel
    {
        public string client_id { get; set; }
        public List<DataModelEvent> events { get; set; }
    }

    public class DataModelEvent
    {
        public string name { get; set; }
        
        [JsonProperty("params")]
        public ParamsObject parameters { get; set; }
    }

    public class ParamsObject
    {
        public string ratio { get; set; }
    }
}
