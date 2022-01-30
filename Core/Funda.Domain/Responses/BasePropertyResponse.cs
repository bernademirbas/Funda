using Newtonsoft.Json;

namespace Funda.Domain.Responses
{
    public class BasePropertyResponse<T>
    {
        [JsonProperty("AccountStatus")]
        public int AccountStatus { get; set; }

        [JsonProperty("EmailNotConfirmed")]
        public bool EmailNotConfirmed { get; set; }

        [JsonProperty("ValidationFailed")]
        public bool ValidationFailed { get; set; }

        [JsonProperty("ValidationReport")]
        public object ValidationReport { get; set; }

        [JsonProperty("Website")]
        public int Website { get; set; }

        [JsonProperty("Metadata")]
        public MetadataResponse Metadata { get; set; }

        [JsonProperty("Objects")]
        public T Objects { get; set; }

        [JsonProperty("Paging")]
        public PagingResponse Paging { get; set; }

        [JsonProperty("TotaalAantalObjecten")]
        public int TotalNumberObjects { get; set; }
    }
}
