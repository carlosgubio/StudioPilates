using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudioPilates.Models
{
    public class Customer_plan
    {
        [Key]
        public int Id_customer_plan { get; set; }

        [ForeignKey("Id_customer")]
        public int Id_customer { get; set; }

        [ForeignKey("Id_plan")]
        public int Id_plan { get; set; }
    }
}
