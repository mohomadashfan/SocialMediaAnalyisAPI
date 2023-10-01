using SocialMediaAnalyis.Shared.DataTransferObjects;

namespace SocialMediaAnalyis.Service.Contracts
{
    public interface ISocialUsersService
    {
        Task<SocialUsersDto> GetUsersByCountry(string country, bool trackChanges);
        Task<IEnumerable<SocialUsersDto>> GetUsersByCountryAsync(string country, bool trackChanges);
    }
}
