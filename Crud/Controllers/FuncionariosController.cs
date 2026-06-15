using Microsoft.AspNetCore.Mvc;
using CrudFuncionariosCompleto.Models;

namespace CrudFuncionariosCompleto.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FuncionariosController : ControllerBase
{
    private static List<Funcionario> funcionarios = new()
    {
        new Funcionario
        {
            Id = 1,
            Nome = "João",
            Cargo = "Analista",
            Salario = 3500
        }
    };

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(funcionarios);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var funcionario = funcionarios.FirstOrDefault(x => x.Id == id);

        if (funcionario == null)
            return NotFound();

        return Ok(funcionario);
    }

    [HttpPost]
    public IActionResult Post(Funcionario funcionario)
    {
        funcionarios.Add(funcionario);

        return CreatedAtAction(
            nameof(GetById),
            new { id = funcionario.Id },
            funcionario);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Funcionario dados)
    {
        var funcionario = funcionarios.FirstOrDefault(x => x.Id == id);

        if (funcionario == null)
            return NotFound();

        funcionario.Nome = dados.Nome;
        funcionario.Cargo = dados.Cargo;
        funcionario.Salario = dados.Salario;

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var funcionario = funcionarios.FirstOrDefault(x => x.Id == id);

        if (funcionario == null)
            return NotFound();

        funcionarios.Remove(funcionario);

        return NoContent();
    }
}