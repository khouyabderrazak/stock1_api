using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Frequent_Entiities;

namespace Stock_Data_Api.Models.Import
{
    public class ChequeOfModeImport : ChequeOfMode
    {
        [DeleteBehavior(DeleteBehavior.Cascade)]
        public PaymentImport PaymentImport { get; set; }
    }
}
