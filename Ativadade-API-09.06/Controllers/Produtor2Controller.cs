using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ativadade_API_09._06.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Produtor2Controller : ControllerBase
    {
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var produtos = new
            {
                id = 1,
                Nome = "Notebook",
                Preco = 4500
                
            };
            return Ok(produtos);
        }
    }
}