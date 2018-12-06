using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPITraining.BLL.Interfaces;
using WebAPITraining.DAL.Interfaces;
using WebAPITraining.DTO;

namespace WebAPITraining.BLL.Impl
{
    public class CountryService : ICountryService
    {
        private ICountryRepository _CountryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _CountryRepository = countryRepository;
        }
        public async Task CreateCountryAsync(CountryModel country)
        {
            await CreateCountryAsync(country);
        }

        public async Task<List<CountryModel>> GetCountriesAsync()
        {
            return await GetCountriesAsync();
        }

        public async Task<CountryModel> GetCountryByIdAsync(int countryId)
        {
            return await GetCountryByIdAsync(countryId);
        }

        public async Task UpdateCountryNameAsync(int countryId, string newCountryName)
        {
            await _CountryRepository.UpdateCountryNameAsync(countryId, newCountryName);
        }
    }
}
