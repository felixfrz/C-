using Entities;

namespace RepositoryContracts
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICountriesRepository
    {
        Task<Country> AddCountry(Country country);

        Task<List<Country>> GetAllCountries();

        Task<Country?> GetCountryByCountryID(Guid countryID);


        Task<Country> GetCountryByCoutryName(string coutryName);
    }
}
