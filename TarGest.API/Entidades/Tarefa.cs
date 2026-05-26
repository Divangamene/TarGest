using System.ComponentModel.DataAnnotations;
using TarGest.API.Enum;

namespace TarGest.API.Entidades
{
    public class Tarefa
    {
        [Key]
        public int tarefaId { get; set; }
        public string tarefaTitulo { get; set; } = string.Empty;
        public string tarefaDescricao { get; set; } = string.Empty;
        public EstadoTarefa estadoTarefa { get; set; }=EstadoTarefa.pedente;
        public DateTime prazoTarefa { get; set; }
        public DateTime horaInicio { get; set; } = DateTime.Now;
    }
}
