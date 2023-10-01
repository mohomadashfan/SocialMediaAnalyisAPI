namespace SocialMediaAnalyis.Service.Contracts
{
    public interface IFifaTweetService
    {
        Task<IEnumerable<FifaHashTagCount>> GetTop20HashTags(bool trackChanges);
        Task<IEnumerable<FifaTweetLanguageCountDTO>> GetTop20TweetLanguage(bool trackChanges);
        Task<IEnumerable<FifaTweetSourceCountDTO>> GetTop5TweetSource(bool trackChanges);
        Task<IEnumerable<TweetCountryDTO>> GetTopTweetCountry(bool trackChanges);
        Task<long?> GetFollowesCount(bool trackChanges);
        Task<int?> GetLikesCount(bool trackChanges);
        Task<int?> GetRetweetsCount(bool trackChanges);
    }
}
