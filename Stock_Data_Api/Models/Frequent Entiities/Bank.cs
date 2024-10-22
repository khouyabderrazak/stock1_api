using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models
{
    public class Bank
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string BankName { get; set; }

        [Required]
        [StringLength(50)]
        public string BranchName { get; set; }

        public string ImagePath { get; set; }
    }

}
