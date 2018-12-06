using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPITraining.DTO
{
    public class CityModel
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
    }
}