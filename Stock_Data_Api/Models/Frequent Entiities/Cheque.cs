using Stock_Data_Api.Models.Commons;
using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models
{
    public class Cheque
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string ChequeNumber { get; set; }

        [Required]
        [StringLength(150)]
        public string AccountHolderName { get; set; }

        [Required]
        [StringLength(20)]
        public string AccountNumber { get; set; }

        public Bank Bank { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        [StringLength(50)]
        public string PayeeName { get; set; }

        public int CurrencyId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime IssueDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; }

        public string Memo { get; set; }

        public string ImagePath { get; set; }

        [Required]
        public ChequeState State { get; set; } // Valid values: 'accepted', 'refused', 'not checked'

    }

}
