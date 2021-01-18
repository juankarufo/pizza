using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly string[] Flavours = new[]
        {
            "Pepperoni", "Carbonara", "Margarita", "Marina", "Roquefort"
        };

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new User
            {
                
            })
            .ToArray();
        }
        
        [HttpPost("login")]
        public User AuthenticateUser( [FromBody] User bodyPost)
        {
            return bodyPost;
        }
    }
}
