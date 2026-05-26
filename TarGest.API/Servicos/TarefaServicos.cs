using TarGest.API.Conexao;
using TarGest.API.DTOS;
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

        public async Task<TarefaDto> CriarTarefa(TarefaDto dto)
        {

            var criar = new Tarefa { 
            
            tarefaTitulo= dto.tarefaTitulo,
            tarefaDescricao= dto.tarefaDescricao,
            estadoTarefa= dto.estadoTarefa,
            prazoTarefa= dto.prazoTarefa,

            };

            await _servico.AddAsync(criar);
           await  _servico.SaveChangesAsync();

            return new TarefaDto
            {
                tarefaTitulo = criar.tarefaTitulo,
                tarefaDescricao = criar.tarefaDescricao,
                estadoTarefa = criar.estadoTarefa,
                prazoTarefa = criar.prazoTarefa
            };

        }
        }
}
