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
    public class CityController : ApiController
    {
        private ICityService _CityService;
        public CityController()
        {

        }

        public CityController(ICityService cityService)
        {
            _CityService = cityService;
        }

        [HttpPut]
        public async Task<IHttpActionResult> CreateCity(CityModel city)
        {
            try
            {
                await _CityService.CreateCityAsync(city);
                return Ok();
            }
            catch (Exception ex)
            {
                //Log
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetCityById(int cityId)
        {
            try
            {
                return Ok(await _CityService.GetCityByIdAsync(cityId));
            }
            catch (Exception ex)
            {
                //Log
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetCitiesByCountryId(int countryId)
        {
            try
            {
                return Ok(await _CityService.GetCitiesByCountryIdAsync(countryId));
            }
            catch (Exception ex)
            {
                //Log
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public async Task<IHttpActionResult> UpdateCityName(int cityId, string newCityName)
        {
            try
            {
                await _CityService.UpdateCityNameAsync(cityId, newCityName);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
