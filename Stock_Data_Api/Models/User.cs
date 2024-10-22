using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models
{
    public class User

    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }
        public string? Role { get; set; } 

        public string? tocken { get; set; } 

        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExperyTime { get; set; }

    }
}
