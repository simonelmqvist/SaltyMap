using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SaltyMap.Classes;

namespace SaltyMap.Models
{
    public class ForcesData
    {
        [JsonProperty(PropertyName = "lat")]
        public double Latitude { get; set; }

        [JsonProperty(PropertyName = "lng")]
        public double Longitude { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Service { get; set; }
    }
}
