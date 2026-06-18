using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ativadade_API_09._06.Controllers
{
    [ApiController]
    [Route("Cadastrar Cliente -8")]
    public class PostCliente8Controller : ControllerBase
    {
        [HttpPost]
public IActionResult Post(string nome)

        {
var cliente = new
{
    Nome = nome
};
return Ok(cliente);
        }
        
    }
}