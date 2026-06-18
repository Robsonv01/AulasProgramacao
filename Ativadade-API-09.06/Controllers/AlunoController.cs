using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ativadade_API_09._06.Controllers
{
    [ApiController]
    [Route("Aluno")]
    public class AlunoController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var aluno = new
            {
                Id = id,
                Nome = "Joao",
                Curso = "Engenharia"
            };

                return Ok(aluno);
         }
    }
}