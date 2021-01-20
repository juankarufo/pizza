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
    public class LoginController : ControllerBase
    {
        /*
        [HttpPost]
        public string Get(string Login,string Password)
        {
            Console.WriteLine("Login post request");

            Console.WriteLine(Login);
            Console.WriteLine(Password);

            if( Login != null 
                && Password != null
                && api.Controllers.UserController.UserList.ContainsKey(Login)
                && api.Controllers.UserController.UserList[Login] == Password
            )
            {
                Console.WriteLine("login ok");
                return "login ok";
            }

            Console.WriteLine("login KO");           
            return "login KO";
        }
        */
        [HttpPost]
        public string Create([FromBody]User user)
        {
            Console.WriteLine("Login post request");

            Console.WriteLine(user.Login);
            Console.WriteLine(user.Password);

            if( user.Login != null 
                && user.Password != null
                && api.Controllers.UserController.UserList.ContainsKey(user.Login)
                && api.Controllers.UserController.UserList[user.Login] == user.Password
            )
            {
                Console.WriteLine("login ok");
                return "login ok";
            }

            Console.WriteLine("login KO");           
            return "login KO";
        }

    }
}
