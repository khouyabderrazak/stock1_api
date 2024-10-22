using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Commons;
using Stock_Data_Api.Models.Sell.Group_Classes;
using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models.Sell
{
    public class InvoiceCreditSell : Invoice
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Client Client { get; set; }

        [DeleteBehavior(DeleteBehavior.SetNull)]
        public InvoiceSellGroup? InvoiceSellGroup { get; set; }
    }
}
