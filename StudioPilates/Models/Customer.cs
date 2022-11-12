using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudioPilates.Models
{
    public class Customer
    {
        public enum CustomerStatus
        {
            Ativo,
            Inativo
        }

        [Key]
        public int Id_customer { get; set; }

        [Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
        [MaxLength(200, ErrorMessage = "O campo \"{0}\" deve ter no máximo \"{1}\" caracteres.")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
        [MaxLength(50)]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "O campo \"{0}\" deve conter um endereço de e-mail válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
        [RegularExpression(@"[0-9]{11}$", ErrorMessage = "O campo \"{0}\" deve ser preenchido com 11 dígitos numéricos.")]
        [MaxLength(11, ErrorMessage = "O campo \"{0}\" deve conter no máximo \"{1}\" caracteres.")]
        [MinLength(11, ErrorMessage = "O campo \"{0}\" deve conter no mínimo \"{1}\" caracteres.")]
        [UIHint("_PhoneTemplate")]
        [Display(Name = "Telefone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
        [MaxLength(1)]
        [Display(Name = "Gênero")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
        [MaxLength(50)]
        [Display(Name = "Ocupação")]
        public string Occupation { get; set; }

        [DataType(DataType.Date, ErrorMessage = "O campo \"{0}\" deve conter uma data válida.")]
        [Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
        [Display(Name = "Data de Nascimento")]
        public DateTime Birth_date { get; set; }

        [Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
        [Display(Name = "Status")]
        public CustomerStatus Status { get; set; }

        public Address Address { get; set; }
    }
}
