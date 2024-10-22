using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Frequent_Entiities;
using Stock_Data_Api.Models.Import;
using Stock_Data_Api.Models.Sell.Group_Classes;
using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models.Commons
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string NReference { get; set; }

        public string NOrder { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EstimatedExpeditionDate { get; set; }

        public string Note { get; set; }

        public string Info { get; set; }

        public OrderState State { get; set; }

        [DeleteBehavior(DeleteBehavior.SetNull)]
        public PaymentCondition? PaymentCondition { get; set; }

        [DeleteBehavior(DeleteBehavior.SetNull)]
        public Seller? Seller { get; set; }

        [DeleteBehavior(DeleteBehavior.SetNull)]
        public PersonToContact? PersonToContact { get; set; }

        [Required]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public TabArticles TabArticles { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        public AssociatedDocs AssociatedDocs { get; set; }

        [DeleteBehavior(DeleteBehavior.SetNull)]
        public Address? DeliveryAddress { get; set; }

        [DeleteBehavior(DeleteBehavior.SetNull)]
        public DeliveryMode? DeliveryMode { get; set; }

        [DeleteBehavior(DeleteBehavior.SetNull)]
        public InvoiceSellGroup? OrderToSupplierGroup { get; set; }

        
    }
}
