using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models
{
    public class PersonToContact
    {
        [Key]
        public int Id { get; set; }

        public int Title { get; set; }

        [Required]
        [StringLength(60)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(60)]
        public string LastName { get; set; }

        [StringLength(50)]
        [EmailAddress]
        public string? Email { get; set; }

        [StringLength(20)]
        public string? PhoneNumberPro { get; set; }

        [StringLength(20)]
        public string? PhoneNumberPortable { get; set; }

        [StringLength(100)]
        public string? Department { get; set; }

        [StringLength(100)]
        public string? Designation { get; set; }
    }
}
