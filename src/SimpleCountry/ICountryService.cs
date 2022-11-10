namespace SimpleCountry;

public interface ICountryService
{
    /// <summary>
    /// Get all the countries
    /// </summary>
    public IEnumerable<Country> GetAll();

    /// <summary>
    /// Get a country by filtering it by common name
    /// </summary>
    /// <param name="name">Example: Brazil</param>
    public Country GetByName(string name);

    /// <summary>
    /// Get a country by filtering it by code, be it alpha2 or alpha3
    /// </summary>
    /// <param name="code">Example: BR</param>
    public Country GetByCode(string code);

    /// <summary>
    /// Get a country by filtering it by Region
    /// </summary>
    /// <param name="region">Example: Europe</param>
    public IEnumerable<Country> GetByRegion(string region);

    /// <summary>
    /// Get a country by filtering it by Sub Region
    /// </summary>
    /// <param name="subRegion">Example: South America</param>
    public IEnumerable<Country> GetBySubRegion(string subRegion);
}