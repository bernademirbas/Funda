using Newtonsoft.Json;

namespace Funda.Domain.Responses
{
    public class PagingResponse
    {
        [JsonProperty("AantalPaginas")]
        public int NumberOfPages { get; set; }

        [JsonProperty("HuidigePagina")]
        public int CurrentPage { get; set; }

        [JsonProperty("VolgendeUrl")]
        public string NextUrl { get; set; }

        [JsonProperty("VorigeUrl")]
        public object BackUrl { get; set; }
    }
}
