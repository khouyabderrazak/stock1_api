using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models.Inventory
{
    public class Mark
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string MarkName { get; set; }
    }
}
