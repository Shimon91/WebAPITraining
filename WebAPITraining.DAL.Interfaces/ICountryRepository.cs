using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPITraining.DTO;

namespace WebAPITraining.DAL.Interfaces
{
    public interface ICountryRepository
    {
        Task CreateCountry(CountryModel country);
        Task<CountryModel> GetCountryById(int countryId);
        Task<List<CountryModel>> GetCountries();
        Task UpdateCountryNameAsync(int countryId, string newCountryName);
    }
}
