using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models.Commons
{
    public class PaymentOfMode
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public PaymentMode PaymentMode { get; set; }

        [Required]
        public int CurrencyId { get; set; }
    }
}
