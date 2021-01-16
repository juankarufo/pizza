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
    public class PizzaController : ControllerBase
    {
        private static readonly string[] Flavours = new[]
        {
            "Pepperoni", "Carbonara", "Margarita", "Marina", "Roquefort"
        };

        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Pizza> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Pizza
            {
                Name = Flavours[(index - 1)%5],
                Units = index
            })
            .ToArray();
        }
    }
}
