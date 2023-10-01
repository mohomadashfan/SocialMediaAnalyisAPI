using Microsoft.AspNetCore.Mvc;
using SocialMediaAnalyis.Service.Contracts;

namespace SocialMediaAnalyis.Presentation.Controllers
{
    [ApiController]
    [Route("api/Fifa")]
    public class FifaTweetController : ControllerBase
    {
        private readonly IServiceManager _service;

        public FifaTweetController(IServiceManager serviceManager)
        {
            _service = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetDataByHastag()
        {
            var dataByHastag = await _service.TweetService.GetTop20HashTags(trackChanges: false);
            return Ok(dataByHastag);
        }

        [HttpGet]
        [Route("TweetSource")]
        public async Task<IActionResult> GetTweetSource()
        {
            var tweetSource = await _service.TweetService.GetTop5TweetSource(trackChanges: false);
            return Ok(tweetSource);
        }

        [HttpGet]
        [Route("TweetLanguage")]
        public async Task<IActionResult> GetTweetLanguage()
        {
            var tweetSource = await _service.TweetService.GetTop20TweetLanguage(trackChanges: false);
            return Ok(tweetSource);
        }

        [HttpGet]
        [Route("Followers")]
        public async Task<IActionResult> GetFollowersCount()
        {
            var followers = await _service.TweetService.GetFollowesCount(trackChanges: false);
            return Ok(followers);
        }

        [HttpGet]
        [Route("Likes")]
        public async Task<IActionResult> GetLikesCount()
        {
            var likes = await _service.TweetService.GetLikesCount(trackChanges: false);
            return Ok(likes);
        }

        [HttpGet]
        [Route("TweetCountry")]
        public async Task<IActionResult> GetTweetCountries()
        {
            var tweetCountries = await _service.TweetService.GetTopTweetCountry(trackChanges: false);
            return Ok(tweetCountries);
        }

        [HttpGet]
        [Route("ReTweet")]
        public async Task<IActionResult> GetReTweetsCount()
        {
            var tweetCount = await _service.TweetService.GetRetweetsCount(trackChanges: false);
            return Ok(tweetCount);
        }
    }
}
