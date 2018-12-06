using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPITraining.BLL.Interfaces;
using WebAPITraining.DAL.Interfaces;
using WebAPITraining.DTO;

namespace WebAPITraining.BLL.Impl
{
    public class ProfileService : IProfileService
    {
        private IProfileRepository _ProfileRepository;

        public ProfileService(IProfileRepository profileRepository)
        {
            _ProfileRepository = profileRepository;
        }
        public async Task CreateProfileAsync(ProfileModel profile)
        {
            await _ProfileRepository.CreateProfileAsync(profile);
        }

        public async Task<ProfileModel> GetProfileByIdAsync(int profileId)
        {
            return await _ProfileRepository.GetProfileByIdAsync(profileId);
        }

        public async Task<List<ProfileModel>> GetProfilesAsync()
        {
            return await _ProfileRepository.GetProfilesAsync();
        }

        public async Task UpdateProfileAsync(ProfileModel profile)
        {
            await _ProfileRepository.UpdateProfileAsync(profile);
        }
    }
}
