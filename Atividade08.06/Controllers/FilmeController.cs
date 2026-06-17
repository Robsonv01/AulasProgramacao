using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Atividade08._06.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmeController : ControllerBase
    {
        [HttpGet]
    
    public IActionResult Get()
        {
            return Ok("Vingadores, Matrix, Interestelar");
        }

    }
}