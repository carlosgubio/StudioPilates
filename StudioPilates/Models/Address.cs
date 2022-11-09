using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudioPilates.Models
{
    //[Owned]
    public class Address
    {
        [Key]
        public int Id_address { get; set; }

        [ForeignKey("Id_customer")]
        public int Id_customer { get; set; }

        //[ForeignKey("Id_customer")]
        //public Customer Customer { get; }

        [Required(ErrorMessage = "O campo{0} é de preenchimento obrigatório.")]
        [MaxLength(10)]
        public string Zip_code { get; set; }

        [Required(ErrorMessage = "O campo{0} é de preenchimento obrigatório.")]
        [MaxLength(50)]
        public string City { get; set; }

        [Required(ErrorMessage = "O campo{0} é de preenchimento obrigatório.")]
        [MaxLength(50)]
        public string State { get; set; }

        [Required(ErrorMessage = "O campo{0} é de preenchimento obrigatório.")]
        [MaxLength(50)]
        public string District { get; set; }

        [Required(ErrorMessage = "O campo{0} é de preenchimento obrigatório.")]
        [MaxLength(100)]
        public string Street { get; set; }

        [Required(ErrorMessage = "O campo{0} é de preenchimento obrigatório.")]
        [MaxLength(10)]
        public string Number { get; set; }

        [Required(ErrorMessage = "O campo{0} é de preenchimento obrigatório.")]
        [MaxLength(100)]
        public string Complement { get; set; }

        [Required(ErrorMessage = "O campo{0} é de preenchimento obrigatório.")]
        [MaxLength(100)]
        public string Reference { get; set; }
    }
}
