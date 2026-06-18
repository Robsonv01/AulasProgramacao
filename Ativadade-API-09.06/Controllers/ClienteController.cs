using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ativadade_API_09._06.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
             var clientes = new []
             {
                 new {id = 1, Nome = "Ana"},
                 new {id = 2, Nome = "Carlos"},
                 new {id = 3, Nome = "Maria"}
             };
            return Ok(clientes);
        }
    }
}