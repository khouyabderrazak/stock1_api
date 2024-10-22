using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock_Data_Api.Models
{
    [Table("Address")]
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string? Country{ get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }

        [MaxLength(100)]
        public string? City { get; set; }

        [MaxLength(100)]
        public string? State { get; set; }

        [MaxLength(20)]
        public string? PostalCode { get; set; }

        [MaxLength(20)]
        public string? PhoneNumber { get; set; }

        [MaxLength(20)]
        public string? Fax { get; set; }
    }
}
