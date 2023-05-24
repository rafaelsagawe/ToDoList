using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ToDoList.Models
{
    public class Tarefa
    {
        [Key]
        public int IdTarefa { get; set; }

        [Required]
        [Display (Name = "Nome")]
        public string? TarefaNome { get; set; }

        [Display (Name = "Descrição")]
        public string? Descricao { get; set; }

        [Display (Name = "Status")]
        public string? Status { get; set; }

        [Display (Name = "Data da Criação")]
        public DateTime? DataCriacao { get; set; } = default(DateTime?);

    }
}
