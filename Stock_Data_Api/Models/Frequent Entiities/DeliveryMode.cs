using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models.Frequent_Entiities
{
    public class DeliveryMode
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Label { get; set; }
    }
}
