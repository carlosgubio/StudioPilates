using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StudioPilates.Models
{
    public class Customer_payment
    {
        [Key]
        public int Id_customer_payment { get; set; }

        [ForeignKey("Id_customer_plan")]
        public int Id_customer_plan { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
        [Display(Name = "Valor Pago")]
        public int Paid_value { get; set; }

        [DataType(DataType.Date, ErrorMessage = "O campo {0} deve conter uma data válida")]
        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
        [Display(Name = "Data do Pagamento")]
        public DateTime Paid_at { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
        [Display(Name = "Forma de Pagamento")]
        public int Payment_method { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
        [Display(Name = "Observação")]
        public int Text { get; set; }
    }
}
