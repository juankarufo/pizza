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
        public string Create([FromBody]User user)
        {
            if( (user.Login != null 
                || user.Password != null)
                && !api.Controllers.UserController.UserList.ContainsKey(user.Login)
            )
            {
                api.Controllers.UserController.UserList.Add(user.Login,user.Password);
                api.Controllers.VoteController.VotesList.Add(user.Login,0);
                Console.WriteLine("signup OK"); 
                return "signup OK";
            }

            Console.WriteLine("signup KO");           
            return "signup KO";
        }

    }
}
