using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPITraining.DTO;

namespace WebAPITraining.BLL.Interfaces
{
    public interface ICityService
    {
        Task CreateCityAsync(CityModel city);
        Task<CityModel> GetCityByIdAsync(int cityId);
        Task<List<CityModel>> GetCitiesByCountryIdAsync(int countryId);
        Task UpdateCityNameAsync(int cityId, string newCityName);
    }
}
