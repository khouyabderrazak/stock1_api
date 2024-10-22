using Stock_Data_Api.Models.Commons;
using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models.Import
{
    public class PaymentOfModeImport : PaymentOfMode
    {
        [Required]
        public PaymentImport PaymentImport { get; set; }
    }
}
