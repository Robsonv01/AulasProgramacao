using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Atividade08._06.Controllers
{
    [ApiController]
    [Route("Produto")]
    public class ProdutoController : ControllerBase
    {
    [HttpGet]
    public IActionResult Get()
        {
            return Ok("Lista de Produtos");
        }
   
    }
}