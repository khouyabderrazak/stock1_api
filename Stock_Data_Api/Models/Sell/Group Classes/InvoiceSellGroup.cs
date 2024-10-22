using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Commons;
using Stock_Data_Api.Models.Import;

namespace Stock_Data_Api.Models.Sell.Group_Classes
{
    public class InvoiceSellGroup : GroupClass
    {
        [DeleteBehavior(DeleteBehavior.SetNull)]
        public InvoiceImport? RelatedInvoiceImport {  get; set; }

        public double MaxAmount { get; set; }
    }
}
