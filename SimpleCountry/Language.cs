using Newtonsoft.Json;

namespace SimpleCountry;

public class Language
{
    [JsonProperty]
    public string Common { get; internal set; }
}