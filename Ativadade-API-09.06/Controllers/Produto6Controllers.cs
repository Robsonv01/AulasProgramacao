using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ativadade_API_09._06.Controllers
{
    [ApiController]
    [Route("Produto-6")]
    public class Produto6Controllers : ControllerBase
    {
        [HttpGet]
        public IActionResult get(string nome)
        {
            if (nome == "Mouse")
            {
                return Ok("Produto encontrado Mouse");
            }
            return Ok("Produto nao encontrado");
        }
    }
}