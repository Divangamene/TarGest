using TarGest.API.Conexao;
using TarGest.API.Entidades;

namespace TarGest.API.Servicos
{
    public class TarefaServicos
    {
        
        public readonly ApiDbContext _servico;
        public TarefaServicos(ApiDbContext servico)
        {
            _servico= servico;
        }

        //criar 

        public async Task<Tarefa> CriarTarefa(Tarefa tarefa)
        {
            _servico.Tarefas.Add(tarefa);
            await _servico.SaveChangesAsync();
            return tarefa;


    }
        }
}
