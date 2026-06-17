using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Atividade08._06.Controllers
{
    [ApiController]
    [Route("Usuário")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]

        public IActionResult get()

        {
            return Ok (new {nome = "Thiago", Idade = "30"});
        }
    }
}