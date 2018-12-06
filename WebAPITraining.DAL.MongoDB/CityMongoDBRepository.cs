using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPITraining.DAL.Common;
using WebAPITraining.DAL.Interfaces;
using WebAPITraining.DTO;

namespace WebAPITraining.DAL.MongoDB
{
    public class CityMongoDBRepository : BaseRepository, ICityRepository
    {
        public async Task CreateCityAsync(CityModel city)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CityModel>> GetCitiesByCountryIdAsync(int countryId)
        {
            throw new NotImplementedException();
        }

        public async Task<CityModel> GetCityByIdAsync(int cityId)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateCityNameAsync(int cityId, string newCityName)
        {
            throw new NotImplementedException();
        }
    }
}
