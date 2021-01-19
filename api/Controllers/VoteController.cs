﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VoteController : ControllerBase
    {
        //user and password list
        public static Dictionary<string, int> VotesList = new Dictionary<string, int>(){
            {"user1@user.com", 4},
            {"user2@user.com", 2},
            {"user3@user.com", 3}
        };

        [HttpGet]
        public IEnumerable<Vote> Get()
        {
            Console.WriteLine("login request");

            return Enumerable.Range(0, VotesList.Count).Select(index => new Vote
            {
                User = VotesList.ElementAt(index).Key,
                Votes = VotesList.ElementAt(index).Value
            })
            .ToArray();
        }

        [HttpPost]
        public string Get(string Login)
        {
            if( VotesList.ContainsKey(Login))
            {
                VotesList[Login] = VotesList[Login] + 1;
                return "ok";
            }
            return "KO";
        }

    }
}
