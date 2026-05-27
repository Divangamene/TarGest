using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TarGest.API.Conexao;
using TarGest.API.DTOS;
using TarGest.API.Entidades;

namespace TarGest.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TarefasController : ControllerBase
{
    private readonly ApiDbContext _context;
    public TarefasController(ApiDbContext context)
    {
        _context = context;
    }
    [HttpPost]
    public async Task<ActionResult> CriarTarefa([FromBody] TarefaDto dto)
    {
        var tarefa = new Tarefa {
            tituloTarefa = dto.tituloTarefa,
            descricaoTarefa = dto.descricaoTarefa,
            estadoTarefa = dto.estadoTarefa,
            prazoTarefa = dto.prazoTarefa,
            horaInicioTarefa = dto.horaInicioTarefa
        };

        await _context.Tarefas.AddRangeAsync(tarefa);
        await _context.SaveChangesAsync();

        return Ok(new TarefaDto {
            tituloTarefa = dto.tituloTarefa,
            descricaoTarefa = dto.descricaoTarefa,
            estadoTarefa = dto.estadoTarefa,
            prazoTarefa = dto.prazoTarefa,
            horaInicioTarefa = dto.horaInicioTarefa

        });
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Tarefa>>> ObterTarefas()
    {
        var tarefas = await _context.Tarefas.ToListAsync();
        await _context.SaveChangesAsync();
        return Ok(tarefas);
    }

    [HttpGet("{tarefaId}")]
    public async Task<ActionResult<Tarefa>> ObterTarefa(int tarefaId)
    {
        var obterId = await _context.Tarefas.FindAsync(tarefaId);
        if (obterId == null)
        {
            return BadRequest();
        }

        return Ok(obterId);
    }
    [HttpDelete("{tarefaId}")]
    public async Task<ActionResult> EliminarTarefa(int tarefaId)
    {
        var elemento = await _context.Tarefas.FindAsync(tarefaId);
        if (elemento == null)
        {
            return NotFound();
        }
         _context.Tarefas.Remove(elemento);
        await _context.SaveChangesAsync();
        return Ok();
    }
    [HttpPut("{tarefaId}")]
    public async Task<ActionResult<Tarefa>> AlterarTarefa([FromBody] TarefaDto dto,int tarefaId)
    {
        var obterElemento = await _context.Tarefas.FindAsync(tarefaId);
        if (obterElemento == null) { 
        return NotFound();
        }

        obterElemento.tituloTarefa = dto.tituloTarefa;
        obterElemento.descricaoTarefa = dto.descricaoTarefa;
        obterElemento.estadoTarefa = dto.estadoTarefa;
        obterElemento.estadoTarefa=dto.estadoTarefa;
        obterElemento.horaInicioTarefa=dto.horaInicioTarefa;
        await _context.SaveChangesAsync();
        return Ok();
    }



}
