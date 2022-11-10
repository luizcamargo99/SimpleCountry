using Newtonsoft.Json;

namespace SimpleCountry;

public class PostalCode
{
    [JsonProperty]
    public string Format { get; internal set; }

    [JsonProperty]
    public string Regex { get; internal set; }
}