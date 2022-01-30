using Newtonsoft.Json;

namespace Funda.Domain.Responses
{
    public class MetadataResponse
    {
        [JsonProperty("ObjectType")]
        public string ObjectType { get; set; }

        [JsonProperty("Omschrijving")]
        public string Description { get; set; }

        [JsonProperty("Titel")]
        public string Title { get; set; }
    }
}
