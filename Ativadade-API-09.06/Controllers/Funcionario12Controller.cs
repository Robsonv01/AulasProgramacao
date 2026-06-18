using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ativadade_API_09._06.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Funcionario12Controller : ControllerBase
    {
    [HttpPost]
    public IActionResult Post(string nome)
        {
            var funcionario = new
            {
                nome = nome
            };
            return Ok(funcionario);
        }
    }
}