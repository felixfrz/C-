using ServiceContracts;

namespace Services
{
    public class CountriesService : ICountriesService
    {
        private List<string> _countries;

        public Guid CountryID
        {
            get
            {
                return Guid.NewGuid();
            }
        }

        public CountriesService()
        {
            _countries = new List<string>()
            {
                "Nigeria", 
                "UK",
                "USA",
                "Canada"
            };
        }


        public List<string> GetCountries()
        {
            return _countries;
        }
    }
}
