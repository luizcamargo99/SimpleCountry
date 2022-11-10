using Newtonsoft.Json;

namespace SimpleCountry;

public class Country
{
    [JsonProperty]
    public Language Name { get; internal set; }

    [JsonProperty]
    public string[] AltSpellings { get; internal set; }

    [JsonProperty]
    public string Alpha2Code { get; internal set; }

    [JsonProperty]
    public string Alpha3Code { get; internal set; }

    [JsonProperty]
    public string Region { get; internal set; }

    [JsonProperty]
    public string SubRegion { get; internal set; }

    [JsonProperty]
    public string[] Capital { get; internal set; }

    [JsonProperty]
    public CountryFlag Flags { get; internal set; }

    [JsonProperty]
    public string[] Borders { get; internal set; }

    [JsonProperty]
    public int Population { get; internal set; }

    [JsonProperty]
    public Map Maps { get; internal set; }

    [JsonProperty]
    public PostalCode PostalCode { get; internal set; }
}