using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulaApi_05._05.Models;
using Microsoft.AspNetCore.Mvc;

namespace AulaApi_05._05.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private static List<Produto> produtos = new List<Produto>()
        {
            new Produto{id = 1, Nome = "Notebook" , Preco = 3500} ,
            new Produto{id = 2, Nome = "Mouse" , Preco = 50} ,
        };

        [HttpGet("Lobsonelegal")]
        public ActionResult<IEnumerable<Produto>> GetTodos() => Ok(produtos);
    }
}