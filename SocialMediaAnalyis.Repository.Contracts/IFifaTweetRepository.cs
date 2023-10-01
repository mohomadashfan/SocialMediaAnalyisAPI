namespace SocialMediaAnalyis.Repository.Contracts
{
    public interface IFifaTweetRepository
    {
        Task<IEnumerable<FifaHashTagCount>> GetHashTagCountTest(bool trackChanges);
        Task<IEnumerable<FifaTweetSourceCountDTO>> GetTweetSourceCount(bool trackChanges);
        Task<IEnumerable<FifaTweetLanguageCountDTO>> GetTweetLanguageCount(bool trackChanges);
        Task<IEnumerable<FollowersCountDTO1>> GetFollowersCount(bool trackChanges);
        Task<IEnumerable<TweetCountryDTO>> GetTweetCountries(bool trackChanges);
        Task<IEnumerable<TotalLikesDTO>> GetTotalLikes(bool trackChanges);
        Task<IEnumerable<TweetsCountDTO>> GetTweetsCount(bool trackChanges);


    }
}
