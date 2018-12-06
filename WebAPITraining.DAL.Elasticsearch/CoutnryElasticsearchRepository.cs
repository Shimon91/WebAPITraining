using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPITraining.DAL.Common;
using WebAPITraining.DAL.Interfaces;
using WebAPITraining.DTO;

namespace WebAPITraining.DAL.Elasticsearch
{
    public class CountryElasticsearchRepository : BaseRepository, ICountryRepository
    {
        public async Task CreateCountry(CountryModel country)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CountryModel>> GetCountries()
        {
            throw new NotImplementedException();
        }

        public async Task<CountryModel> GetCountryById(int countryId)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateCountryNameAsync(int countryId, string newCountryName)
        {
            throw new NotImplementedException();
        }
    }
}
