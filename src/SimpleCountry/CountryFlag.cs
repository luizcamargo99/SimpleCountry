using Newtonsoft.Json;

namespace SimpleCountry;

public class CountryFlag
{
    [JsonProperty]
    public string Png { get; internal set; }

    [JsonProperty]
    public string Svg { get; internal set; }
}