using Entities;
using RepositoryContracts;

namespace Repositories
{
    public class CountriesRepositories : ICountriesRepository
    {
        private readonly ApplicationDbContext _db;

        public CountriesRepositories(ApplicationDbContext db)
        {
            _db = db;
        }

        public Task<Country> AddCountry(Country country)
        {
            throw new NotImplementedException();
        }

        public Task<List<Country>> GetAllCountries()
        {
            throw new NotImplementedException();
        }

        public Task<Country?> GetCountryByCountryID(Guid countryID)
        {
            throw new NotImplementedException();
        }

        public Task<Country> GetCountryByCoutryName(string coutryName)
        {
            throw new NotImplementedException();
        }
    }
}
