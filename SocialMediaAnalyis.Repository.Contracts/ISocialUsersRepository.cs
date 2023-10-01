using SocialMediaAnalyis.Entities.Models;

namespace SocialMediaAnalyis.Repository.Contracts
{
    public interface ISocialUsersRepository
    {
        Task<SocialMediaUsers> GetUsersByCountry(string country, bool trackChanges);
        Task<IEnumerable<SocialMediaUsers>> GetUsersByCountryAsync(string country, bool trackChanges);
    }
}
