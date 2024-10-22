using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Commons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock_Data_Api.Models.Sell
{
    public class PaymentSell : Payment
    {
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Client Client { get; set; }

        public List<PaymentOfModeSell> PaymentOfModes { get; set; }
    }



}
