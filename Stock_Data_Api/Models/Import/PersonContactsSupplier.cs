using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Sell;
using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models.Import
{
    public class PersonContactsSupplier
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public PersonToContact PersonToContact { get; set; }

        [Required]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Supplier Supplier { get; set; }
    }
}
