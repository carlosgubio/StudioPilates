using System.ComponentModel.DataAnnotations;

namespace StudioPilates.Models
{
    public class Question
    {
        [Key]
        public int Id_question { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
        [MaxLength(200, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
        [Display(Name = "Pergunta")]
        public string Text { get; set; }
    }
}
