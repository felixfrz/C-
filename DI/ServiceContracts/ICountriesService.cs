namespace ServiceContracts
{
    public interface ICountriesService
    {
        public Guid CountryID { get; }
        public List<string> GetCountries();
    }
}
