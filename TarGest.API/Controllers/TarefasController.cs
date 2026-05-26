using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TarGest.API.Conexao;

namespace TarGest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly ApiDbContext _context;
        public TarefasController(ApiDbContext contex)
        {
           _context= contex; 
        }

    }
}
