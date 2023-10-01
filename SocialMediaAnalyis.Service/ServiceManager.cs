using AutoMapper;
using SocialMediaAnalyis.Repository.Contracts;
using SocialMediaAnalyis.Service.Contracts;

namespace SocialMediaAnalyis.Service
{
    public partial class ServiceManager : IServiceManager
    {

        private readonly Lazy<ISocialUsersService> _usersService;
        private readonly Lazy<IFifaTweetService> _tweetService;
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _usersService = new Lazy<ISocialUsersService>(() => new SocialUsersService(repositoryManager, logger, mapper));
            _tweetService = new Lazy<IFifaTweetService>(() => new FifaTweetService(repositoryManager, logger, mapper));
        }

        public ISocialUsersService UsersService => _usersService.Value;

        public IFifaTweetService TweetService => _tweetService.Value;
    }
}