using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Commons;
using Stock_Data_Api.Models.Import.Group_Classes;
using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models.Import
{
    public class InvoiceCreditImport : Invoice
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Supplier Supplier { get; set; }

        [DeleteBehavior(DeleteBehavior.SetNull)]
        public InvoiceImportCreditGroup? InvoiceImportGroup { get; set; }
    }
}
