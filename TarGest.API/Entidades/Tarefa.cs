using System.ComponentModel.DataAnnotations;
using TarGest.API.Enum;

namespace TarGest.API.Entidades
{
    public class Tarefa
    {
        [Key]
        public int tarefaId { get; set; }
        public string tituloTarefa { get; set; } = string.Empty;
        public string descricaoTarefa { get; set; } = string.Empty;
        public EstadoTarefa estadoTarefa { get; set; } = EstadoTarefa.pedente;
        public DateTime prazoTarefa { get; set; } = DateTime.Today;
        public DateTime horaInicioTarefa { get; set; } = DateTime.Now;
    }
}
