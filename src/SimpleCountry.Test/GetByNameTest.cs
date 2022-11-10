namespace SimpleCountry.Test
{
    public class GetByNameTest
    {
        [Theory]
        [InlineData("Brazil")]
        [InlineData("Spain")]
        [InlineData("IReLaNd")]
        [InlineData("Argentina")]
        [InlineData("Japan")]
        [InlineData("peru")]
        [InlineData("chinA")]
        public void GetByNameSuccessTest(string name)
        {
            ICountryService service = new CountryService();
            var country = service.GetByName(name);
            Assert.NotNull(country);
        }

        [Theory]
        [InlineData("")]
        [InlineData("Sp ain")]
        [InlineData(" ")]
        [InlineData("dssdsdds")]
        [InlineData(null)]
        public void GetByNameFailTest(string name)
        {
            ICountryService service = new CountryService();
            var country = service.GetByName(name);
            Assert.Null(country);
        }
    }
}