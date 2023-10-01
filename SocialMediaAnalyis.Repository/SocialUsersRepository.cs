using Microsoft.EntityFrameworkCore;
using SocialMediaAnalyis.Entities.Models;
using SocialMediaAnalyis.Repository.Contracts;

namespace SocialMediaAnalyis.Repository
{
    public partial class SocialUsersRepository : RepositoryBase<SocialMediaUsers>, ISocialUsersRepository
    {
        public SocialUsersRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<SocialMediaUsers> GetUsersByCountry(string country, bool trackChanges) => await FindByCondition(x => x.Country.Equals(country), trackChanges).FirstAsync();

        public async Task<IEnumerable<SocialMediaUsers>> GetUsersByCountryAsync(string country, bool trackChanges) => await FindByCondition(x => x.Country.Equals(country), trackChanges).ToListAsync();
    }
}
