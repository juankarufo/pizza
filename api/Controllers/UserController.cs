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
        public static Dictionary<string, string> UserList = new Dictionary<string, string>(){
            {"user1@user.com", "1234"},
            {"user2@user.com", "1234"},
            {"user3@user.com", "1234"}
        };

    }
}
