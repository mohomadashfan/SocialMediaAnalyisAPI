using Microsoft.EntityFrameworkCore;
using SocialMediaAnalyis.Entities.Models;
using SocialMediaAnalyis.Repository.Contracts;

namespace SocialMediaAnalyis.Repository
{
    public partial class FifaTweetRepository : RepositoryBase<Fifa>, IFifaTweetRepository
    {
        public FifaTweetRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<FifaHashTagCount>> GetHashTagCountTest(bool trackChanges)
        {
            return await FindAll(trackChanges).Where(x => x.HashTags != String.Empty)
                .GroupBy(x => x.HashTags)
                .Select(o => new FifaHashTagCount
                {
                    Count = o.Count(),
                    HasTag = o.Key,
                })
                .OrderByDescending(x => x.Count).Take(20)
                .ToListAsync();
        }


        public async Task<IEnumerable<FifaTweetSourceCountDTO>> GetTweetSourceCount(bool trackChanges)
        {
            return await FindAll(trackChanges).Where(x => x.TweetSource != String.Empty)
                .GroupBy(x => x.TweetSource)
                .Select(o => new FifaTweetSourceCountDTO
                {
                    Count = o.Count(),
                    TweetSource = o.Key
                }).OrderByDescending(x => x.Count).Take(5).ToListAsync();
        }

        public async Task<IEnumerable<FollowersCountDTO1>> GetFollowersCount(bool trackChanges)
        {
            return await FindAll(trackChanges).Where(x => x.FollowersCount != null)
                .Select(o => new FollowersCountDTO1
                {
                    Followers = o.FollowersCount
                }).ToListAsync();
        }

        public async Task<IEnumerable<TweetCountryDTO>> GetTweetCountries(bool trackChanges)
        {
            return await FindAll(trackChanges).Where(x => x.Location != String.Empty)
                .GroupBy(x => x.Location)
                .Select(o => new TweetCountryDTO
                {
                    Count = o.Count(),
                    CountryName = o.Key
                }).OrderByDescending(x => x.Count).Take(15).ToListAsync();
        }

        public async Task<IEnumerable<TotalLikesDTO>> GetTotalLikes(bool trackChanges)
        {
            return await FindAll(trackChanges).Where(x => x.Likes != null)
                .Select(o => new TotalLikesDTO
                {
                    Likes = o.Likes
                }).ToListAsync();
        }

        public async Task<IEnumerable<TweetsCountDTO>> GetTweetsCount(bool trackChanges)
        {
            return await FindAll(trackChanges).Where(x => x.ReTweet != null)
                 .Select(o => new TweetsCountDTO
                 {
                     Retweet = o.ReTweet
                 }).ToListAsync();
        }

        public async Task<IEnumerable<FifaTweetLanguageCountDTO>> GetTweetLanguageCount(bool trackChanges)
        {
            return await FindAll(trackChanges).Where(x => x.TweetLanguage != String.Empty && x.TweetLanguage != null)
                 .GroupBy(x => x.TweetLanguage)
                 .Select(o => new FifaTweetLanguageCountDTO
                 {
                     Count = o.Count(),
                     TweetLanguage = o.Key
                 }).OrderByDescending(x => x.Count).Take(10).ToListAsync();
        }
    }
}
