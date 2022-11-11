using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Alteração
//namespace StudioPilates.Models
//{

//    //[Owned]
//    public class Address
//    {
//        [Key]
//        public int Id_address { get; set; }

//        [ForeignKey("Id_customer")]
//        public int Id_customer { get; set; }

//        //[ForeignKey("Id_customer")]
//        //public Customer Customer { get; }

//        [Required(ErrorMessage = "O campo{0} é de preenchimento obrigatório.")]
//        [MaxLength(10)]
//        public string Zip_code { get; set; }

//        [Required(ErrorMessage = "O campo{0} é de preenchimento obrigatório.")]
//        [MaxLength(50)]
//        public string City { get; set; }

//        [Required(ErrorMessage = "O campo{0} é de preenchimento obrigatório.")]
//        [MaxLength(50)]
//        public string State { get; set; }

//        [Required(ErrorMessage = "O campo{0} é de preenchimento obrigatório.")]
//        [MaxLength(50)]
//        public string District { get; set; }

//        [Required(ErrorMessage = "O campo{0} é de preenchimento obrigatório.")]
//        [MaxLength(100)]
//        public string Street { get; set; }

//        [Required(ErrorMessage = "O campo{0} é de preenchimento obrigatório.")]
//        [MaxLength(10)]
//        public string Number { get; set; }

//        [Required(ErrorMessage = "O campo{0} é de preenchimento obrigatório.")]
//        [MaxLength(100)]
//        public string Complement { get; set; }

//        [Required(ErrorMessage = "O campo{0} é de preenchimento obrigatório.")]
//        [MaxLength(100)]
//        public string Reference { get; set; }
//    }
//}
//Alteração



namespace StudioPilates.Models
{
    [Owned]
    public class Address
    {
        [Required(ErrorMessage = "O CEP informado não retornou um endereço válido.")]
        [MaxLength(100, ErrorMessage = "O campo {0} deve conter no máximo {1} caracteres.")]
        public string Street { get; set; }

        [Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
        [MaxLength(10, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        [Display(Name = "Número")]
        public string Number { get; set; }

        [MaxLength(100, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        [Display(Name = "Complemento")]
        public string Complement { get; set; }

        [Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        public string District { get; set; }

        [Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        public string City { get; set; }

        [Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
        [MaxLength(2, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        public string State { get; set; }

        [Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
        [RegularExpression(@"[0-9]{8}$", ErrorMessage = "O campo \"{0}\" deve ser preenchido com um CEP válido.")]
        [MaxLength(8, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        [UIHint("_CepTemplate")]
        [Display(Name = "CEP")]
        public string Zip_code { get; set; }

        [MaxLength(100, ErrorMessage = "O campo \"{0}\" deve conter no máximo {1} caracteres.")]
        [Display(Name = "Referência")]
        public string Reference { get; set; }
    }
}

