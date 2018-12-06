using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPITraining.DTO;

namespace WebAPITraining.BLL.Interfaces
{
    public interface IProfileService
    {
        Task CreateProfileAsync(ProfileModel profile);
        Task<ProfileModel> GetProfileByIdAsync(int profileId);
        Task<List<ProfileModel>> GetProfilesAsync();
        Task UpdateProfileAsync(ProfileModel profile);
    }
}
