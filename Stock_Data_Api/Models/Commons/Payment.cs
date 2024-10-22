using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models.Commons
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string N_Payment { get; set; }

        public string N_Reference { get; set; }

        public decimal BankCharges { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public AssociatedDocs AssociatedDocs { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; }

        public string Comment { get; set; }
    }
}
