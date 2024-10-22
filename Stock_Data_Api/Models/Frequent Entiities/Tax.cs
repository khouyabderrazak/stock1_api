using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models
{
    public class Tax
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [Range(0, 100)]
        public decimal Ratio { get; set; }
    }
}
