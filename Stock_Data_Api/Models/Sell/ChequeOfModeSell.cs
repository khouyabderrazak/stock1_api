using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Commons;

namespace Stock_Data_Api.Models.Sell
{
    public class ChequeOfModeSell : PaymentOfMode
    {
        [DeleteBehavior(DeleteBehavior.Cascade)]
        public PaymentSell PaymentSell { get; set; }
    }
}
