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
    public class ProfileController : ApiController
    {
        private IProfileService _ProfileService;
        public ProfileController()
        {

        }

        public ProfileController(IProfileService profileService)
        {
            _ProfileService = profileService;
        }

        [HttpPut]
        public async Task<IHttpActionResult> CreateProfile(ProfileModel profile)
        {
            try
            {
                await _ProfileService.CreateProfileAsync(profile);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetProfileById(int profileId)
        {
            try
            {
                return Ok(await _ProfileService.GetProfileByIdAsync(profileId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetProfiles()
        {
            try
            {
                return Ok(await _ProfileService.GetProfilesAsync());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public async Task<IHttpActionResult> UpdateProfile(ProfileModel profile)
        {
            try
            {
                await _ProfileService.UpdateProfileAsync(profile);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
