using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Funda.Domain.Responses
{
    public class PropertyResponse
    {
        [JsonProperty("AangebodenSindsTekst")]
        public string OfferedSinceText { get; set; }

        [JsonProperty("AanmeldDatum")]
        public DateTime? LoginDate { get; set; }

        [JsonProperty("AantalBeschikbaar")]
        public object AmountAvailable { get; set; }

        [JsonProperty("AantalKamers")]
        public int NumberOfRooms { get; set; }

        [JsonProperty("AantalKavels")]
        public object NumberOfLots { get; set; }

        [JsonProperty("Aanvaarding")]
        public string Acceptance { get; set; }

        [JsonProperty("Adres")]
        public string Address { get; set; }

        [JsonProperty("Afstand")]
        public int Distance { get; set; }

        [JsonProperty("BronCode")]
        public string SourceCode { get; set; }

        [JsonProperty("ChildrenObjects")]
        public List<object> ChildrenObjects { get; set; }

        [JsonProperty("DatumAanvaarding")]
        public DateTime? AcceptanceDate { get; set; }

        [JsonProperty("DatumOndertekeningAkte")]
        public DateTime? SignedDeedDate  { get; set; }

        [JsonProperty("Foto")]
        public string Photo { get; set; }

        [JsonProperty("FotoLarge")]
        public string LargePhoto { get; set; }

        [JsonProperty("FotoLargest")]
        public string LargestPhoto { get; set; }

        [JsonProperty("FotoMedium")]
        public string MediumPhoto { get; set; }

        [JsonProperty("FotoSecure")]
        public string SecurePhoto { get; set; }

        [JsonProperty("GewijzigdDatum")]
        public DateTime? ModifiedDate { get; set; }

        [JsonProperty("GlobalId")]
        public int GlobalId { get; set; }

        [JsonProperty("GroupByObjectType")]
        public string GroupByObjectType { get; set; }

        [JsonProperty("Heeft360GradenFoto")]
        public bool Has360DegreePhoto { get; set; }

        [JsonProperty("HeeftBrochure")]
        public bool HasBrochure { get; set; }

        [JsonProperty("HeeftOpenhuizenTopper")]
        public bool HasOpenHousesTopper { get; set; }

        [JsonProperty("HeeftOverbruggingsgrarantie")]
        public bool HasBridgingWarranty { get; set; }

        [JsonProperty("HeeftPlattegrond")]
        public bool HasMap { get; set; }

        [JsonProperty("HeeftTophuis")]
        public bool HasTopHouse { get; set; }

        [JsonProperty("HeeftVeiling")]
        public bool HasAuction { get; set; }

        [JsonProperty("HeeftVideo")]
        public bool HasVideo { get; set; }

        [JsonProperty("HuurPrijsTot")]
        public object RentPriceTo { get; set; }

        [JsonProperty("Huurprijs")]
        public object RentPrice { get; set; }

        [JsonProperty("HuurprijsFormaat")]
        public object RentPriceSize { get; set; }

        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("InUnitsVanaf")]
        public object InUnitsFrom { get; set; }

        [JsonProperty("IndProjectObjectType")]
        public bool IndProjectObjectType { get; set; }

        [JsonProperty("IndTransactieMakelaarTonen")]
        public object IndTransactionBrokerShow { get; set; }

        [JsonProperty("IsSearchable")]
        public bool IsSearchable { get; set; }

        [JsonProperty("IsVerhuurd")]
        public bool IsRented { get; set; }

        [JsonProperty("IsVerkocht")]
        public bool HasBeenSold { get; set; }

        [JsonProperty("IsVerkochtOfVerhuurd")]
        public bool IsSoldOrRented { get; set; }

        [JsonProperty("Koopprijs")]
        public int PurchasePrice { get; set; }

        [JsonProperty("KoopprijsFormaat")]
        public string PurchasePriceSize { get; set; }

        [JsonProperty("KoopprijsTot")]
        public int PurchasePriceTo { get; set; }

        [JsonProperty("Land")]
        public object Country { get; set; }

        [JsonProperty("MakelaarId")]
        public int EstateAgentId { get; set; }

        [JsonProperty("MakelaarNaam")]
        public string EstateAgentName { get; set; }

        [JsonProperty("MobileURL")]
        public string MobileUrl { get; set; }

        [JsonProperty("Note")]
        public object Note { get; set; }

        [JsonProperty("OpenHuis")]
        public List<object> OpenHouse { get; set; }

        [JsonProperty("Oppervlakte")]
        public int Surface { get; set; }

        [JsonProperty("Perceeloppervlakte")]
        public int PlotArea { get; set; }

        [JsonProperty("Postcode")]
        public string PostalCode { get; set; }

        [JsonProperty("Prijs")]
        public PriceResponse Price { get; set; }

        [JsonProperty("PrijsGeformatteerdHtml")]
        public string PriceFormattedHtml { get; set; }

        [JsonProperty("PrijsGeformatteerdTextHuur")]
        public string PriceFormattedTextRent { get; set; }

        [JsonProperty("PrijsGeformatteerdTextKoop")]
        public string PriceFormattedTextBuy { get; set; }

        [JsonProperty("Producten")]
        public List<string> Products { get; set; }

        [JsonProperty("Project")]
        public ProjectResponse Project { get; set; }

        [JsonProperty("ProjectNaam")]
        public object ProjectName { get; set; }

        [JsonProperty("PromoLabel")]
        public PromotionLabelResponse PromoLabel { get; set; }

        [JsonProperty("PublicatieDatum")]
        public DateTime? PublicationDate { get; set; }

        [JsonProperty("PublicatieStatus")]
        public int PublicationStatus { get; set; }

        [JsonProperty("SavedDate")]
        public DateTime? SavedDate { get; set; }

        [JsonProperty("Soort-aanbod")]
        public string Type_Offer { get; set; }

        [JsonProperty("SoortAanbod")]
        public int TypeOffer { get; set; }

        [JsonProperty("StartOplevering")]
        public object StartDelivery { get; set; }

        [JsonProperty("TimeAgoText")]
        public object TimeAgoText { get; set; }

        [JsonProperty("TransactieAfmeldDatum")]
        public DateTime? TransactionUnsubscribeDate { get; set; }

        [JsonProperty("TransactieMakelaarId")]
        public object TransactionEstateAgentId { get; set; }

        [JsonProperty("TransactieMakelaarNaam")]
        public object TransactionEstateAgentName { get; set; }

        [JsonProperty("TypeProject")]
        public int TypeProject { get; set; }

        [JsonProperty("URL")]
        public string Url { get; set; }

        [JsonProperty("VerkoopStatus")]
        public string SalesStatus { get; set; }

        [JsonProperty("WGS84_X")]
        public double WGS84X { get; set; }

        [JsonProperty("WGS84_Y")]
        public double WGS84Y { get; set; }

        [JsonProperty("WoonOppervlakteTot")]
        public int LivingAreaTo { get; set; }

        [JsonProperty("Woonoppervlakte")]
        public int LivingSpace { get; set; }

        [JsonProperty("Woonplaats")]
        public string Residence { get; set; }

        [JsonProperty("ZoekType")]
        public List<int> SearchType { get; set; }
    }
}
