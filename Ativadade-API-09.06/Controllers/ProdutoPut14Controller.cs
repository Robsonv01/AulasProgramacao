using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ativadade_API_09._06.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoPut14Controller : ControllerBase
    {
        private static double preco = 100;
        [HttpGet]
                public IActionResult Get()
        {
            return Ok(preco);
        }

        [HttpPut]
        public IActionResult Put(double precoNovo)
        {
            preco = precoNovo;
            return Ok(preco);
        }
    }
}