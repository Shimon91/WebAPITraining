using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPITraining.DTO;

namespace WebAPITraining.BLL.Interfaces
{
    public interface ICountryService
    {
        Task CreateCountryAsync(CountryModel country);
        Task<CountryModel> GetCountryByIdAsync(int countryId);
        Task<List<CountryModel>> GetCountriesAsync();
        Task UpdateCountryNameAsync(int countryId, string newCountryName);
    }
}
