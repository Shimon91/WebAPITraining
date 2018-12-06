using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPITraining.BLL.Interfaces;
using WebAPITraining.DTO;

namespace WebAPITraining.Controllers
{
    public class CountryController : ApiController
    {
        private ICountryService _CountryService;
        public CountryController()
        {

        }

        public CountryController(ICountryService countryService)
        {
            _CountryService = countryService;
        }

        [HttpPut]
        public async Task<IHttpActionResult> CreateCountry(CountryModel country)
        {
            try
            {
                await _CountryService.CreateCountryAsync(country);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetCountryById(int countryId)
        {
            try
            {
                return Ok(await _CountryService.GetCountryByIdAsync(countryId));
                
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetCountries()
        {
            try
            {
                return Ok(await _CountryService.GetCountriesAsync());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public async Task<IHttpActionResult> UpdateCountryName(int countryId, string newCountryName)
        {
            try
            {
                await _CountryService.UpdateCountryNameAsync(countryId, newCountryName);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
