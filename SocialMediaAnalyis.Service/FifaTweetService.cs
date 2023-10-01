using AutoMapper;
using SocialMediaAnalyis.Repository.Contracts;
using SocialMediaAnalyis.Service.Contracts;

namespace SocialMediaAnalyis.Service
{
    internal sealed class FifaTweetService : IFifaTweetService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public FifaTweetService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<int?> GetRetweetsCount(bool trackChanges)
        {
            var allData = await _repository.FifaTweet.GetTweetsCount(trackChanges);
            if (allData == null)
            {
                throw new Exception("");
            }

            var returnAllData = _mapper.Map<IEnumerable<TweetsCountDTO>>(allData);
            int? sumLikes = returnAllData.Sum(x => (int?)x.Retweet);
            return sumLikes;
        }

        public async Task<long?> GetFollowesCount(bool trackChanges)
        {
            var allData = await _repository.FifaTweet.GetFollowersCount(trackChanges);
            if (allData == null)
            {
                throw new Exception("");
            }

            var returnAllData = _mapper.Map<IEnumerable<FollowersCountDTO1>>(allData);
            long? sumFollowers = returnAllData.Sum(x => (long?)x.Followers);
            return sumFollowers;
        }


        public async Task<int?> GetLikesCount(bool trackChanges)
        {
            var allData = await _repository.FifaTweet.GetTotalLikes(trackChanges);
            if (allData == null)
            {
                throw new Exception("");
            }

            var returnAllData = _mapper.Map<IEnumerable<TotalLikesDTO>>(allData);
            int? sumLikes = returnAllData.Sum(x => (int?)x.Likes);
            return sumLikes;
        }

        public async Task<IEnumerable<FifaHashTagCount>> GetTop20HashTags(bool trackChanges)
        {
            var dtos = await _repository.FifaTweet.GetHashTagCountTest(trackChanges);
            return (dtos);
        }

        public async Task<IEnumerable<FifaTweetSourceCountDTO>> GetTop5TweetSource(bool trackChanges)
        {
            var dtos = await _repository.FifaTweet.GetTweetSourceCount(trackChanges);
            return (dtos);
        }

        public async Task<IEnumerable<TweetCountryDTO>> GetTopTweetCountry(bool trackChanges)
        {
            var dtos = await _repository.FifaTweet.GetTweetCountries(trackChanges);
            return (dtos);
        }

        public async Task<IEnumerable<FifaTweetLanguageCountDTO>> GetTop20TweetLanguage(bool trackChanges)
        {
            var dtos = await _repository.FifaTweet.GetTweetLanguageCount(trackChanges);
            return (dtos);
        }
    }
}
