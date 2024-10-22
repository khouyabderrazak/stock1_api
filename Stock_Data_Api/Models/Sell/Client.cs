using Microsoft.EntityFrameworkCore;
using Stock_Data_Api.Models.Commons;
using Stock_Data_Api.Models.Import;
using System.ComponentModel.DataAnnotations;

namespace Stock_Data_Api.Models.Sell
{
    public class Client : SupplierClient
    {
        public List<PersonContactsClient>? ClientContacts { get; set; }
    }
}
