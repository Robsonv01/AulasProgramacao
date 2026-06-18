using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ativadade_API_09._06.Controllers
{
      [ApiController]
    [Route("ClienteID-15")]
    public class ClientePut15Controller : ControllerBase
    {
        private static List<Cliente> clientes = new List<Cliente>
        {
            new Cliente { Id = 1, Nome = "João" },
            new Cliente { Id = 2, Nome = "Maria" }
        };

        [HttpPut("{id}")]
        public IActionResult Put(int id, Cliente clienteNovo)
        {
            var cliente = clientes.FirstOrDefault(c => c.Id == id);

            if (cliente == null)
                return NotFound();

            cliente.Nome = clienteNovo.Nome;

            return Ok(cliente);
        }
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}