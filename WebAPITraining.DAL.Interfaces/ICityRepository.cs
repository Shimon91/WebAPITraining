using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPITraining.DTO;

namespace WebAPITraining.DAL.Interfaces
{
    public interface ICityRepository
    {
        Task CreateCityAsync(CityModel city);
        Task<CityModel> GetCityByIdAsync(int cityId);
        Task<List<CityModel>> GetCitiesByCountryIdAsync(int countryId);
        Task UpdateCityNameAsync(int cityId, string newCityName);
    }
}
