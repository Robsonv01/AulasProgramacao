using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Ativadade_API_09._06.Controllers
{
     [ApiController]
    [Route("Livro")]
    public class Livro11Controller : ControllerBase
    {
        public static List<string> livros = new List<string>();

        [HttpPost]
        public IActionResult Post([FromForm] string titulo)
        {
            livros.Add(titulo);
            return Ok(livros);
        }
    }
}