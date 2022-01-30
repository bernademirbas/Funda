using Newtonsoft.Json;

namespace Funda.Domain.Responses
{
    public class PriceResponse
    {
        [JsonProperty("GeenExtraKosten")]
        public bool NoExtraCosts { get; set; }

        [JsonProperty("HuurAbbreviation")]
        public string RentAbbreviation { get; set; }

        [JsonProperty("Huurprijs")]
        public object RentPrice { get; set; }

        [JsonProperty("HuurprijsOpAanvraag")]
        public string RentPriceOnRequest { get; set; }

        [JsonProperty("HuurprijsTot")]
        public object RentPriceTo { get; set; }

        [JsonProperty("KoopAbbreviation")]
        public string BuyAbbreviation { get; set; }

        [JsonProperty("Koopprijs")]
        public int PurchasePrice { get; set; }

        [JsonProperty("KoopprijsOpAanvraag")]
        public string PurchasePriceOnRequest { get; set; }

        [JsonProperty("KoopprijsTot")]
        public int PurchasePriceTo { get; set; }

        [JsonProperty("OriginelePrijs")]
        public object OriginalPrice { get; set; }

        [JsonProperty("VeilingText")]
        public string AuctionText { get; set; }
    }
}
