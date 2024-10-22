using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Stock_Data_Api.Models.Commons;
using System.Text.Json.Serialization;
using Stock_Data_Api.Models.Frequent_Entiities;
using Stock_Data_Api.Models.Inventory;

namespace Stock_Data_Api.Models.Sell
{
    public class InvoiceSell
    {
        [Key]
        public int Id { get; set; }
        
        public int ClientId { get; set; }
        [ForeignKey(nameof(ClientId))]
        public Client? Client { get; set; } = null;

        public string? GeneralConditions { get; set; }
        public string NInvoice { get; set; }
        public string? NOrder { get; set; }

        public int? PaymentConditionId { get; set; }
        [ForeignKey(nameof(PaymentConditionId))]
        public PaymentCondition? PaymentCondition { get; set; } = null;

        public DateTime? InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public int? SellerId { get; set; }
        [ForeignKey(nameof(SellerId))]
        public Seller? Seller { get; set; } = null;
        public string? Note { get; set; }

        public TabArticles? TabArticles { get; set; }

        public int? AssociatedDocsId { get; set; } 
        [ForeignKey(nameof(AssociatedDocsId))]
        public AssociatedDocs? AssociatedDocs { get; set; } = null;
    }
}
