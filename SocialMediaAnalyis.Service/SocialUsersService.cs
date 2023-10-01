using AutoMapper;
using SocialMediaAnalyis.Repository.Contracts;
using SocialMediaAnalyis.Service.Contracts;
using SocialMediaAnalyis.Shared.DataTransferObjects;

namespace SocialMediaAnalyis.Service
{
    internal sealed class SocialUsersService : ISocialUsersService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SocialUsersService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<SocialUsersDto> GetUsersByCountry(string country, bool trackChanges)
        {
            var userCountry = await _repository.SocialUsers.GetUsersByCountry(country, trackChanges);

            if (userCountry == null)
            {
                throw new Exception("");
            }
            var userCountryReturn = _mapper.Map<SocialUsersDto>(userCountry);

            return userCountryReturn;
        }

        public async Task<IEnumerable<SocialUsersDto>> GetUsersByCountryAsync(string country, bool trackChanges)
        {
            var userCountry = await _repository.SocialUsers.GetUsersByCountryAsync(country, trackChanges);

            if (userCountry == null)
            {
                throw new Exception("");
            }
            var userCountryReturn = _mapper.Map<IEnumerable<SocialUsersDto>>(userCountry);

            return userCountryReturn;
        }
    }
}
