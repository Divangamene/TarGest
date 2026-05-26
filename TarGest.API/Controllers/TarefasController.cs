using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TarGest.API.Conexao;
using TarGest.API.Entidades;

namespace TarGest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly ApiDbContext _context; 
       
    }
}
