namespace SimpleCountry.Test
{
    public class GetByCodeTest
    {
        [Theory]
        [InlineData("BR")]
        [InlineData("BRA")]
        public void GetBrazilByCodeSuccessTest(string code)
        {
            ICountryService service = new CountryService();
            var country = service.GetByCode(code);
            Assert.Equal("Brazil", country.Name.Common);
        }

        [Theory]
        [InlineData("PT")]
        [InlineData("PRT")]
        public void GetPortugalByCodeSuccessTest(string code)
        {
            ICountryService service = new CountryService();
            var country = service.GetByCode(code);
            Assert.Equal("Portugal", country.Name.Common);
        }

        [Theory]
        [InlineData("ES")]
        [InlineData("ESP")]
        public void GetSpainByCodeSuccessTest(string code)
        {
            ICountryService service = new CountryService();
            var country = service.GetByCode(code);
            Assert.Equal("Spain", country.Name.Common);
        }
        [Theory]
        [InlineData("ESPSAPAS")]
        [InlineData(" ")]
        [InlineData("")]
        [InlineData("Null")]
        [InlineData(null)]
        public void GeByCodeFailTest(string code)
        {
            ICountryService service = new CountryService();
            var country = service.GetByCode(code);
            Assert.Null(country);
        }
    }
}