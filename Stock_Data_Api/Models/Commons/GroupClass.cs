using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models.Commons
{
    public class GroupClass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Label { get; set; }
    }
}
