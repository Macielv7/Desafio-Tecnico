using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApi_Tarefas.Model
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O título não pode exceder 50 caracteres.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "A Descricao é obrigatório.")]
        [MaxLength(100, ErrorMessage = "A Descricao não pode exceder 100 caracteres.")]
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Concluida { get; set; }
    }
}