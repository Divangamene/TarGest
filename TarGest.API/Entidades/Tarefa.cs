using System.ComponentModel.DataAnnotations;

namespace TarGest.API.Entidades
{
    public class Tarefa
    {
        [Key]
        public int tarefaId { get; set; }
        public string tarefaTitulo { get; set; } = string.Empty;
        public string tarefaDescricao { get; set; } = string.Empty;
        public DateTime tarefaPrazo { get; set; }
        public DateTime horaInicio { get; set; } = DateTime.Now;
    }
}
