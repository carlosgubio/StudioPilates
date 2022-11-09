using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudioPilates.Models
{
    public class Customer_question_response
    {
        [Key]
        public int Id_customer_question_response { get; set; }

        [ForeignKey("Id_customer")]
        public int Id_customer { get; set; }

        [ForeignKey("Id_question")]
        public int Id_question { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
        [Display(Name = "Respostas")]
        public int Response { get; set; }
    }
}
