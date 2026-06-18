using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ativadade_API_09._06.Controllers
{
    [ApiController]
    [Route("Produto")]
    public class Produto7Controller : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(string nome, double preco)
        {
            var produto = new
            {
                Nome = nome,
                Preco = preco
            };
            return Ok(produto);
        }
    }
}