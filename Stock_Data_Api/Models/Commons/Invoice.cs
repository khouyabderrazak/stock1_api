using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Frequent_Entiities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Stock_Data_Api.Models.Commons
{
    public class Invoice
    {
        public string NInvoice { get; set; }

        public string? NOrder { get; set; }

        public int? PaymentConditionId { get; set; }
        [DeleteBehavior(DeleteBehavior.SetNull)]
        [ForeignKey(nameof(PaymentConditionId))]
        [JsonIgnore]
        public PaymentCondition? PaymentCondition { get; set; }

        [DataType(DataType.Date)]
        public DateTime? InvoiceDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; }

        public int? SellerId { get; set; }
        [DeleteBehavior(DeleteBehavior.SetNull)]
        [ForeignKey(nameof(SellerId))]
        [JsonIgnore]
        public Seller? Seller { get; set; }

        public string? Note { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        public TabArticles? TabArticles { get; set; }



        public int? AssociatedDocsId { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [ForeignKey(nameof(AssociatedDocsId))]
        [JsonIgnore]
        public AssociatedDocs? AssociatedDocs { get; set; }

    }
}
