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
    public class ProfileElasticsearchRepository : BaseRepository, IProfileRepository
    {
        public async Task CreateProfileAsync(ProfileModel profile)
        {
            throw new NotImplementedException();
        }

        public async Task<ProfileModel> GetProfileByIdAsync(int profileId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProfileModel>> GetProfilesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateProfileAsync(ProfileModel profile)
        {
            throw new NotImplementedException();
        }
    }
}
