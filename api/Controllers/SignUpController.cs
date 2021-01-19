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
    public class SignUpController : ControllerBase
    {
        [HttpPost]
        public string Get(string Login,string Password)
        {
            Console.WriteLine("Login post request");

            if( (Login != null 
                || Password != null)
                && !api.Controllers.UserController.UserList.ContainsKey(Login)
            )
            {
                api.Controllers.UserController.UserList.Add(Login,Password);
                api.Controllers.VoteController.VotesList.Add(Login,0);
                return "signup OK";
            }

            Console.WriteLine("signup KO");           
            return "signup KO";
        }

    }
}
