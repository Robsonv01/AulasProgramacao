using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ativadade_API_09._06.Controllers
{
    [ApiController]
    [Route("Produto")]
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var produtos = new []
            {
            new {Id = 1, Nome = "Notebook", Preco = 4500},
            new {Id = 2, Nome = "Mouse", Preco = 100},
            new {Id = 3, Nome = "Teclado", Preco = 250},
                
            };
            return Ok (produtos);
        }
    }
}