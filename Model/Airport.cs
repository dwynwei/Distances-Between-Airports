using Newtonsoft.Json;
using System;

namespace Model
{
    public class Airport
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }

        [JsonProperty("_geoloc")]
        public Geolocation GeoLocation { get; set; }

        public double Latitude => GeoLocation?.Lat ?? 0.0;
        public double Longitude => GeoLocation?.Lng ?? 0.0;

    }
}
