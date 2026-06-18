using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ativadade_API_09._06.Controllers
{
    [ApiController]
    [Route("Aluno")]
    public class PostAluno9Controller : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(string nome)
        {
            var aluno = new
            {
                nome = nome
            };
            return Ok(aluno);
        }
    }
}