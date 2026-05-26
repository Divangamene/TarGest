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
    public async Task<ActionResult> CriarTarefa([FromBody]TarefaDto dto)
    {
        var tarefa = new Tarefa { 
        tituloTarefa=dto.tituloTarefa,
        descricaoTarefa=dto.descricaoTarefa,
        estadoTarefa=dto.estadoTarefa,
        prazoTarefa =dto.prazoTarefa,
        horaInicioTarefa=dto.horaInicioTarefa
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
   
}
