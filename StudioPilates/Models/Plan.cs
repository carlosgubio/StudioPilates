using System.ComponentModel.DataAnnotations;

namespace StudioPilates.Models
{
    public class Plan
    {
        [Key]
        public int Id_plan { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
        //[DataType(DataType.Currency)] ** Reconhecer como valor monetário **
        [Display(Name = "Valor")]
        public int Price { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
        [Display(Name = "Recorrência do Pagamento")]
        public string Payment_recurrence { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
        [Display(Name = "Duração em meses.")]
        public string Contract_recurrence { get; set; }
    }
}
