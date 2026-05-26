using Microsoft.EntityFrameworkCore;
using TarGest.API.Entidades;

namespace TarGest.API.Conexao
{
    public class ApiDbContext: DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
