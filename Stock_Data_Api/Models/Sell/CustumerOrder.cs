using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Commons;
using Stock_Data_Api.Models.Sell.Group_Classes;

namespace Stock_Data_Api.Models.Sell
{
    public class CustumerOrder : Order
    {
        public Client Client { get; set; }

        [DeleteBehavior(DeleteBehavior.SetNull)]
        public PaymentSell? Payment { get; set; }

        [DeleteBehavior(DeleteBehavior.SetNull)]
        public ClientOrderGroup? Group { get; set; }
    }
}
