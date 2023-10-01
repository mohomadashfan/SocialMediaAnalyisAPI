using Microsoft.AspNetCore.Mvc;
using SocialMediaAnalyis.Service.Contracts;

namespace SocialMediaAnalyis.Presentation.Controllers
{
    [ApiController]
    [Route("api/Socialusers")]
    public class SocialUsersController : ControllerBase
    {
        private readonly IServiceManager _service;

        public SocialUsersController(IServiceManager serviceManager)
        {
            _service = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsersByCountry(string country)
        {
            var usersByCountry = await _service.UsersService.GetUsersByCountry(country, trackChanges: false);
            return Ok(usersByCountry);
        }

        [HttpGet]
        [Route("ByCountry")]
        public async Task<IActionResult> GetAllUsersByCountryAsync(string country)
        {
            var usersByCountry = await _service.UsersService.GetUsersByCountryAsync(country, trackChanges: false);
            return Ok(usersByCountry);
        }

    }
}
