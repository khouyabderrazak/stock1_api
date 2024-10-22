using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Commons;
using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models.Sell
{
    public class PaymentOfModeSell : PaymentOfMode
    {
        [Required]
        public PaymentSell PaymentSell { get; set; }
    }
}
