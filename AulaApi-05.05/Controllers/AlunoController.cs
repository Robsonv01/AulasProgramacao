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
    public class AlunoController : ControllerBase
    {
        private static List<Aluno> alunos = new List<Aluno>()
{
    new Aluno{ Id = 1, Nome = "João", Idade = 20 },
    new Aluno{ Id = 2, Nome = "Maria", Idade = 22 },
};
        [HttpGet("alunos")]
        public ActionResult<IEnumerable<Aluno>> GetTodos() => Ok(alunos);
    }
}