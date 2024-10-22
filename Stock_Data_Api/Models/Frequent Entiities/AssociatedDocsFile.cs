using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock_Data_Api.Models
{
    public class AssociatedDocsFile
    {
        public int Id { get; set; }

        [Required]
        public string FilePath { get; set; }
        public string? Label { get; set; }
    
    }
}
