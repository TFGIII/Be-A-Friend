using API_Test.Model;
using Microsoft.AspNetCore.Mvc;

namespace API_Test.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class FriendController : ControllerBase
    {
        private static readonly List<Friend> _friend = Friend.GetFriends();

        private readonly ILogger<FriendController> _logger;

        public FriendController(ILogger<FriendController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetFriendList")]

        public IEnumerable<Friend> Get() => Friend.GetFriends();

    }
}
