using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ativadade_API_09._06.Controllers
{
    [ApiController]
    [Route("Produto")]
    public class Produto4Controller : ControllerBase
    {
        [HttpGet("maior-100")]
        public IActionResult Get()
        {
            var produtos = new []
            {
                new { Id = 1, Nome = "Notebook", Preco = 4500.00m },
                                new { Id = 3, Nome = "Teclado", Preco = 300.00m }

            };
            return Ok(produtos);
        }
    }
}