using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPITraining.BLL.Interfaces;
using WebAPITraining.DAL.Interfaces;
using WebAPITraining.DTO;

namespace WebAPITraining.BLL.Impl
{
    public class CityService : ICityService
    {
        private ICityRepository _CityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _CityRepository = cityRepository;
        }
        public async Task CreateCityAsync(CityModel city)
        {
            await _CityRepository.CreateCityAsync(city);
        }

        public async Task<List<CityModel>> GetCitiesByCountryIdAsync(int countryId)
        {
            return await _CityRepository.GetCitiesByCountryIdAsync(countryId);
        }

        public async Task<CityModel> GetCityByIdAsync(int cityId)
        {
            return await _CityRepository.GetCityByIdAsync(cityId);
        }

        public async Task UpdateCityNameAsync(int cityId, string newCityName)
        {
            await _CityRepository.UpdateCityNameAsync(cityId, newCityName);
        }
    }
}
