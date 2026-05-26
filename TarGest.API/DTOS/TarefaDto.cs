using TarGest.API.Enum;

namespace TarGest.API.DTOS
{
    public class TarefaDto
    {
        public string tarefaTitulo { get; set; } = string.Empty;
        public string tarefaDescricao { get; set; } = string.Empty;
        public EstadoTarefa estadoTarefa { get; set; } = EstadoTarefa.pedente;
        public DateTime prazoTarefa { get; set; }
        public DateTime horaInicio { get; set; } = DateTime.Now;
    }
}
