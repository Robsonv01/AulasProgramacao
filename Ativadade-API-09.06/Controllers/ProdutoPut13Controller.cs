using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ativadade_API_09._06.Controllers
{
        [ApiController]
    [Route("Produto-put")]
    public class ProdutoPut13Controller : ControllerBase
    {
        private static string produto = "Mouse";

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(produto);
        }

        [HttpPut("{nomeAlteracao}")]
        public IActionResult Put(string nomeAlteracao)
        {
            produto = nomeAlteracao;
            return Ok(produto);
        }
    }
}