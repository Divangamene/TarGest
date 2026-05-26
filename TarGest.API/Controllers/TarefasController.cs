using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TarGest.API.Conexao;
using TarGest.API.Entidades;
using TarGest.API.Servicos;

namespace TarGest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly TarefaServicos _servico;
        public TarefasController(TarefaServicos servicos)
        {
            _servico = servicos;
        }

        [HttpPost]
        public async Task<ActionResult> CriarNovaTarefa([FromBody]TarefaServicos sc)
        {
            _servico.CriarTarefa.Add(sc);
            return Ok();

        }
       
    }
}
