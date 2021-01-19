using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //user and password list
        private Dictionary<string, string> UserList = new Dictionary<string, string>(){
            {"user1@user.com", "1234"},
            {"user2@user.com", "1234"},
            {"user3@user.com", "1234"}
        };

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        /* GET /user  */
        [HttpGet]
        public IEnumerable<User> Get()
        {
            Console.WriteLine("login request");

            return Enumerable.Range(0, UserList.Count).Select(index => new User
            {
                Login = UserList.ElementAt(index).Key,
                Password = "hidden"
            })
            .ToArray();
        }
        
        [HttpPost] /* post route with fields "User" and "Password" from "User" model contained in "User.cs"*/
        public string Get(string Login)
        {
            Console.WriteLine("hibodysdfsdfsdf");
            Console.WriteLine(Login);
                        
            return Login;
            //always true so always logged for this test
        }

        /*
        Idea for signup

        [HttpPost("signup")] 
        public bool SignUpUser( [FromBody] User bodyPost)
        {
            Console.WriteLine("hibodyPost");
            Console.WriteLine(bodyPost);

             if (!UserList.ContainsKey("anadido@user.com"))
                {UserList.Add("anadido@user.com","Three");}
                        
            return true;
            //always true so always logged for this test
        }
        */
    }
}
