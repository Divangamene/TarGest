using TarGest.API.Enum;

namespace TarGest.API.DTOS
{
    public class TarefaDto
    {
        public string tituloTarefa { get; set; } = string.Empty;
        public string descricaoTarefa { get; set; } = string.Empty;
        public EstadoTarefa estadoTarefa { get; set; } = EstadoTarefa.pedente;
        public DateTime prazoTarefa { get; set; }
        public DateTime horaInicioTarefa { get; set; } = DateTime.Now;
    }
}
