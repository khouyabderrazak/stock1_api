using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models
{
    public class PaymentCondition
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Label { get; set; }
    }
}
