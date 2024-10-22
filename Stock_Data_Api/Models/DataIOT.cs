using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models
{
    public class DataIOT
    {
        [Key]
        public int Id { get; set; }
        public string? X1 { get; set; }

        public string? X2 { get; set; }
        public string? X3 { get; set; }


    }
}
