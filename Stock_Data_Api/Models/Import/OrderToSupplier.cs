using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Commons;
using Stock_Data_Api.Models.Import.Group_Classes;

namespace Stock_Data_Api.Models.Import
{
    public class OrderToSupplier : Order
    {
        public Supplier Supplier { get; set; }

        [DeleteBehavior(DeleteBehavior.SetNull)]
        public PaymentImport? Payment { get; set; }

        [DeleteBehavior(DeleteBehavior.SetNull)]
        public OrderToSupplierGroup? Group { get; set; }
    }

}
