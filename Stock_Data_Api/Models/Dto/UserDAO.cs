using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models
{
    public class UserDAO
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
    }
}
