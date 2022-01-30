using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Funda.Domain.Responses
{

    public class ProjectResponse
    {
        [JsonProperty("AantalKamersTotEnMet")]
        public object NumberRoomsUntilAndWith { get; set; }

        [JsonProperty("AantalKamersVan")]
        public object NumberOfRooms { get; set; }

        [JsonProperty("AantalKavels")]
        public object NumberOfLots { get; set; }

        [JsonProperty("Adres")]
        public object Address { get; set; }

        [JsonProperty("FriendlyUrl")]
        public object FriendlyUrl { get; set; }

        [JsonProperty("GewijzigdDatum")]
        public DateTime? ModifiedDate { get; set; }

        [JsonProperty("GlobalId")]
        public object GlobalId { get; set; }

        [JsonProperty("HoofdFoto")]
        public string MainPhoto { get; set; }

        [JsonProperty("IndIpix")]
        public bool IndIpix { get; set; }

        [JsonProperty("IndPDF")]
        public bool IndPdf { get; set; }

        [JsonProperty("IndPlattegrond")]
        public bool IndMap { get; set; }

        [JsonProperty("IndTop")]
        public bool IndTop { get; set; }

        [JsonProperty("IndVideo")]
        public bool IndVideo { get; set; }

        [JsonProperty("InternalId")]
        public string InternalId { get; set; }

        [JsonProperty("MaxWoonoppervlakte")]
        public object MaxLivingArea { get; set; }

        [JsonProperty("MinWoonoppervlakte")]
        public object MinLivingArea { get; set; }

        [JsonProperty("Naam")]
        public object Name { get; set; }

        [JsonProperty("Omschrijving")]
        public object Description { get; set; }

        [JsonProperty("OpenHuizen")]
        public List<object> OpenHouses { get; set; }

        [JsonProperty("Plaats")]
        public object Venue { get; set; }

        [JsonProperty("Prijs")]
        public object Price { get; set; }

        [JsonProperty("PrijsGeformatteerd")]
        public object PriceFormatted { get; set; }

        [JsonProperty("PublicatieDatum")]
        public DateTime? PublicationDate { get; set; }

        [JsonProperty("Type")]
        public int Type { get; set; }

        [JsonProperty("Woningtypen")]
        public object HomeTypes { get; set; }
    }
}
