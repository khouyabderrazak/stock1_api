using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock_Data_Api.Models.Commons
{
    public class SupplierClient
    {
        [Key]
        public int Id { get; set; }

        //MR,MMe,Mm....
        public int Title { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }
        [Required]
        public ClientType Type { get; set; }

        [Required]
        [StringLength(50)]
        public string DisplayName { get; set; }

        [StringLength(255)]
        [EmailAddress]
        public string? Email { get; set; }

        [StringLength(20)]
        public string? PhonePro { get; set; }

        [StringLength(20)]
        public string? PhonePortable { get; set; }

        public string? Note { get; set; }

        //Still Need A Trigger For Delete

        public int? BillingAddressId { get; set; }
        [ForeignKey(nameof(BillingAddressId))]
        public Address? BillingAddress { get; set; }

        //Still Need A Trigger For Delete

        public int? DeliveryAddressId { get; set; }
        [ForeignKey(nameof(DeliveryAddressId))]
        public Address? DeliveryAddress { get; set; }


        public int? CurrencyId { get; set; }

        public int? taxId { get; set; }
        [ForeignKey(nameof(taxId))]
        public Tax? Tax { get; set; }

        public int? PaymentConditionId { get; set; }
        [ForeignKey(nameof(PaymentConditionId))]
        public PaymentCondition? PaymentCondition { get; set; }

       
        [DeleteBehavior(DeleteBehavior.Cascade)]
        public AssociatedDocs? AssociatedDocs { get; set; }
    }
}
