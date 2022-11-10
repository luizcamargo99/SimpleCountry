namespace SimpleCountry.Test
{
    public class GetAllTest
    {
        [Fact]
        public void GetAllSuccessTest()
        {
            ICountryService service = new CountryService();
            var countries = service.GetAll();
            Assert.Equal(250, countries.Count());
        }
    }
}