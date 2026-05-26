using Microsoft.EntityFrameworkCore;
using TarGest.API.Entidades;

namespace TarGest.API.Conexao
{
    public class ApiDbContext: DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options):base(options) 
        {
            
        }
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
