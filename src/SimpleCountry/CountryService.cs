using Newtonsoft.Json;
using System.Reflection;

namespace SimpleCountry;

public class CountryService : ICountryService
{
    private readonly IEnumerable<Country> _countries;

    public CountryService()
    {
        var currentAssembly = Assembly.GetExecutingAssembly();
        var streamReader = new StreamReader(currentAssembly.GetManifestResourceStream("SimpleCountry.countries.json"));
        _countries = JsonConvert.DeserializeObject<IEnumerable<Country>>(streamReader.ReadToEnd()).OrderBy(x => x.Name.Common).ToList();
    }

    public IEnumerable<Country> GetAll()
    {
        return _countries;
    }

    public Country GetByName(string name)
    {
        return string.IsNullOrEmpty(name) ? null : _countries.FirstOrDefault(x => x.Name.Common.ToLower() == name.ToLower());
    }

    public Country GetByCode(string code)
    {
        if (string.IsNullOrEmpty(code))
        {
            return null;
        }

        var upperCode = code.ToUpper();
        return _countries.FirstOrDefault(x => x.Alpha2Code == upperCode || x.Alpha3Code == upperCode);
    }

    public IEnumerable<Country> GetByRegion(string region)
    {
        return string.IsNullOrEmpty(region) ? null : _countries.Where(x => x.Region.ToLower() == region.ToLower()).OrderBy(x => x.Name.Common);
    }

    public IEnumerable<Country> GetBySubRegion(string subRegion)
    {
        return string.IsNullOrEmpty(subRegion) ? null : _countries.Where(x => x.SubRegion.ToLower() == subRegion.ToLower()).OrderBy(x => x.Name.Common);
    }
}