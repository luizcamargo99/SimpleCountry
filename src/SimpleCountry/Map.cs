using Newtonsoft.Json;

namespace SimpleCountry;

public class Map
{
    [JsonProperty]
    public string GoogleMaps { get; internal set; }

    [JsonProperty]
    public string OpenStreetMaps { get; internal set; }
}