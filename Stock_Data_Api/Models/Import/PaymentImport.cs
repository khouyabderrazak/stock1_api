using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Commons;

namespace Stock_Data_Api.Models.Import
{
    public class PaymentImport : Payment
    {
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Supplier Supplier { get; set; }

        public List<PaymentOfModeImport> PaymentOfModes { get; set; }
    }
}
