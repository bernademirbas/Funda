using System.Collections.Generic;
using Newtonsoft.Json;

namespace Funda.Domain.Responses
{
    public class PromotionLabelResponse
    {
        [JsonProperty("HasPromotionLabel")]
        public bool HasPromotionLabel { get; set; }

        [JsonProperty("PromotionPhotos")]
        public List<string> PromotionPhotos { get; set; }

        [JsonProperty("PromotionPhotosSecure")]
        public List<string> PromotionPhotosSecure { get; set; }

        [JsonProperty("PromotionType")]
        public int PromotionType { get; set; }

        [JsonProperty("RibbonColor")]
        public int RibbonColor { get; set; }

        [JsonProperty("RibbonText")]
        public object RibbonText { get; set; }

        [JsonProperty("Tagline")]
        public string TagLine { get; set; }
    }
}
