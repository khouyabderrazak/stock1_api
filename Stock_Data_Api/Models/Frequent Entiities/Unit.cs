using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models
{
    public class Unit
    {
        [Key]
        public int Id { get; set; }
        public string Label { get; set; }
    }
}
