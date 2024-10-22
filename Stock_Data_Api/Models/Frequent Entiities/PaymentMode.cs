using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models
{
    public class PaymentMode
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Label { get; set; }

        public string Description { get; set; }
    }
}