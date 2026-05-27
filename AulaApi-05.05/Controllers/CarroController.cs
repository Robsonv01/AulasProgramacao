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
    public class CarroController : ControllerBase
    {
        private static List<Carro> carros = new List<Carro>()
{
    new Carro{ Id = 1, Nome = "João", Idade = 20 },
    new Carro{ Id = 2, Nome = "Maria", Idade = 22 },
};

        public static List<Carro> Carros { get => carros; set => carros = value; }

        [HttpGet("Carros")]
        public ActionResult<IEnumerable<Carro>> GetTodos() => Ok(Carros);
    }
}
